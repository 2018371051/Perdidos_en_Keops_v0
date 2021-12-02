using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Murcielagos : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            Debug.Log("Te ha hecho daño los murciélagos");
            other.GetComponent<Life>().TomarDaño(1);
        }
    }
}
