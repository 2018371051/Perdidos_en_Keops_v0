using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class skeleton : MonoBehaviour
{
    void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.collider.CompareTag("Player"))
        {
            Debug.Log("Te ha hecho daño el esqueleto");
            collision.collider.GetComponent<Life>().TomarDaño(1);
        }
    }
}
