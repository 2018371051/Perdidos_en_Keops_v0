using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDamage : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.CompareTag("Player"))
        {
            Debug.Log("Te ha hecho da�o la momia");
            other.GetComponent<Life>().TomarDa�o(1);
        }
    }
}
