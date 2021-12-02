using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Hearts : MonoBehaviour
{
    public int numeroVidas = 3;
    public Life life;

    public Image[] hearts;
    public Sprite fullHeart;
    public Sprite emptyHeart;

    public void Update()
    {
        int vida = life.vida;
        if (vida <= 0 && numeroVidas >= 1)
        {
            numeroVidas = numeroVidas - 1;
            GetComponent<Life>().Corazones();
        }
        if(vida <= 0 && numeroVidas <= 0)
        {
            Destroy(gameObject);
        }

        for (int i=0; i<hearts.Length; i++)
        {
            
            
            if(vida >= 1 && i < numeroVidas)
            {
                hearts[i].enabled = true;
            }
            else
            {
                hearts[i].enabled = false;
            }
        }
    }
}
