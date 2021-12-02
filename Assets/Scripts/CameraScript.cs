using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraScript : MonoBehaviour
{
    public GameObject Jones;

    void Update()
    {
        if(Jones != null)
        {
            Vector3 position = transform.position;
            position.x = Jones.transform.position.x;
            transform.position = position;
        }
    }
}
