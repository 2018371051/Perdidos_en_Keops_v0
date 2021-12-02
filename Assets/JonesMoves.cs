using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class JonesMoves : MonoBehaviour
{
    public float Speed;
    public float JumpForce;
    private Rigidbody2D Rigidbody2D;
    private Animator Animator;
    private float Horizontal;
    private bool Grounded;
    public int score;
    public Text TXTScore;
    void Start()
    {
        Rigidbody2D = GetComponent<Rigidbody2D>();
        Animator = GetComponent<Animator>();
    }

    void Update()
    {
        TXTScore.text = "Score: " + score;


        Horizontal = Input.GetAxisRaw("Horizontal");
        

        if (Horizontal < 0.0f) transform.localScale = new Vector3(-0.4454f, 0.4454f, 0.4454f);
        else if (Horizontal > 0.0f) transform.localScale = new Vector3(0.4454f, 0.4454f, 0.4454f);

        Animator.SetBool("running", Horizontal != 0.0f);

        Debug.DrawRay(transform.position, Vector3.down * 0.9f, Color.red);
        if (Physics2D.Raycast(transform.position, Vector3.down, 0.9f))
        {
            Grounded = true;
        }
        else Grounded = false;

        if (Input.GetKeyDown(KeyCode.W) && Grounded)
        {
            Jump();
        }
        if (Input.GetKeyDown(KeyCode.S))
        { 
            Crawl();
        }
        else if (Input.GetKeyUp(KeyCode.S))
        {
            transform.Rotate(new Vector3(0f, 0f, 90f));
        }
    }

        private void Crawl()
        {
            transform.Rotate(new Vector3(0f, 0f, -90f));
        }
    private void Jump()
    {
        Rigidbody2D.AddForce(Vector2.up * JumpForce);
    }

    private void FixedUpdate()
    {
        Rigidbody2D.velocity = new Vector2(Horizontal * Speed, Rigidbody2D.velocity.y);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Coin")
        {
            score++;
            Destroy(collision.gameObject);
        }
    }
}
