using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class SpawnManagerX : MonoBehaviour
{
    public GameObject[] ballPrefabs; // Lista de prefabs de bolas a instanciar

    //Limites de generacion de las pelotas
    private float spawnLimitXLeft = -22; 
    private float spawnLimitXRight = 7;  

    private float spawnPosY = 30;  // Altura desde donde caen las bolas

    private float startDelay = 1.0f;   // Tiempo de espera antes de empezar a generar

    void Start()
    {
        // Inicia la corutina que genera bolas aleatoriamente
        StartCoroutine(SpawnRandomBallCoroutine());
    }

    // Corutina para generar bolas con intervalo aleatorio
    IEnumerator SpawnRandomBallCoroutine()
    {
        // Espera inicial
        yield return new WaitForSeconds(startDelay);

        while (true) // Bucle infinito para seguir generando bolas
        {
            SpawnRandomBall();

            // Tiempo aleatorio entre cada bola
            float spawnInterval = Random.Range(3.0f, 5.0f);
            yield return new WaitForSeconds(spawnInterval);
        }
    }

    // Funcion que genera una bola en posicion aleatoria
    void SpawnRandomBall()
    {
        // Selecciona una bola aleatoria
        int randomIndex = Random.Range(0, ballPrefabs.Length);

        // Genera una posicion aleatoria dentro de los limites
        Vector3 spawnPos = new Vector3(Random.Range(spawnLimitXLeft, spawnLimitXRight), spawnPosY, 0);
        Instantiate(ballPrefabs[randomIndex], spawnPos, ballPrefabs[randomIndex].transform.rotation);
    }
}
