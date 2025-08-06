using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveForwardX : MonoBehaviour
{
    public float speed; 

    void Update()
    {
        // Mueve el objeto hacia adelante segun la velocidad establecida
        transform.Translate(Vector3.forward * speed * Time.deltaTime);
    }
}
