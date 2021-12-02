using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class skeletonMoves : MonoBehaviour
{
    public GameObject Jones;
    private Animator Animator;
    void Start()
    {
        Animator = GetComponent<Animator>();
    }
    void Update()
    {
        if (Jones == null) return;
        float distance = Mathf.Abs(Jones.transform.position.x - transform.position.x);

        if (distance < 1.0f)
        {
          Animator.SetBool("scaring", true);
        }
        else Animator.SetBool("scaring", false);
    }
}
