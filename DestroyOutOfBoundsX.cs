using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBoundsX : MonoBehaviour
{
    private float leftLimit = -30; // Limite izquierdo para destruir perros
    private float bottomLimit = -5;  // Limite inferior para destruir pelotas

    void Update()
    {
        // Si el objeto se sale por la izquierda (perros)
        if (transform.position.x < leftLimit)
        {
            Destroy(gameObject); // Destruye el objeto
        } 
        // Si el objeto cae por debajo del limite (pelotas)
        else if (transform.position.y < bottomLimit)
        {
            Debug.Log("Game Over"); // Mensaje de aviso en consola
            Destroy(gameObject); // Destruye el objeto
        }
    }
}
