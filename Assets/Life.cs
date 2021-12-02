using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Life : MonoBehaviour
{
    public int vida;
    public int maximoVida;
    

    void Start()
    {
        vida = maximoVida;
    }

    public void TomarDaño(int daño)
    {
        vida -= daño;
        if (vida <= 0)
        {
            GetComponent<Hearts>().Update();
        }
    }
    public void Corazones()
    {
        vida = 10;
    }
}
