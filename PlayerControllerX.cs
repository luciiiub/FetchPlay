using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;  
    private float dogSpawnY = 0f;    // Altura en la que aparece el perro (suelo)

    void Update()
    {
        // Si se presiona la tecla espacio, se crea un nuevo perro
        if (Input.GetKeyDown(KeyCode.Space))
        {
            // Posicion donde aparecera el perro (misma X y Z que el jugador, Y en el suelo)
            Vector3 spawnPosition = new Vector3(transform.position.x, dogSpawnY, transform.position.z);
            Instantiate(dogPrefab, spawnPosition, dogPrefab.transform.rotation);
        }
    }
}
