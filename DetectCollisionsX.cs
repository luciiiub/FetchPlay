using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCollisionsX : MonoBehaviour
{
    // Se ejecuta cuando el objeto entra en contacto con un trigger
    private void OnTriggerEnter(Collider other)
    {
        // Destruye este objeto 
        Destroy(gameObject);
    }
}
