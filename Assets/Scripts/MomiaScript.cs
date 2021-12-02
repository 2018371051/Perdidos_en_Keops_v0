using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MomiaScript : MonoBehaviour
{
    public GameObject Jones;
    public float velocidad;
    public Transform player;
    public Rigidbody2D Rigidbody2D;
    private Animator Animator;

    void Start()
    {
        Animator = GetComponent<Animator>();
    }

    void Update()
    {
        //Para corregit el error de cuando Jones muera
        if (Jones == null) return;
        //Para que el enemigo siempre voltee a ver a Jones
        Vector3 direction = Jones.transform.position - transform.position;
        if (direction.x >= 0.0f) transform.localScale = new Vector3(-0.2997346f, 0.3114157f, 0.2379035f);
        else transform.localScale = new Vector3(0.2997346f, 0.3114157f, 0.2379035f);
        //Si el enemigo está cerca, que lo persiga
        float distance = Mathf.Abs(Jones.transform.position.x - transform.position.x);

        if (distance < 7.0f)
        {
            Chase();
        }
        //Si el enemigo no está cerca, que no haga ningún movimiento (se quede parado)
        else Animator.SetBool("running", false);
    }
    //El método que hace que lo persiga
    private void Chase()
    {
        Vector2 objetivo = new Vector2(player.position.x, player.position.y);
        Vector2 nuevaPos = Vector2.MoveTowards(Rigidbody2D.position, objetivo, velocidad * Time.deltaTime);
        Rigidbody2D.MovePosition(nuevaPos);
        //Que haga la animación cuando lo persiga
        Animator.SetBool("running", true);
    }
}
