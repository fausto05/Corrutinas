using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemigos : MonoBehaviour
{
    public GameObject prefabEnemigo;
    public float rangoX = 10f;
    public float rangoZ = 10f;
    public float intervalo = 3f;
    void Start()
    {
        InvokeRepeating("InstanciarEnemigo", 0f, intervalo);
    }

    void InstanciarEnemigo()
    {
        Vector3 posicionAleatoria = new Vector3(Random.Range(-rangoX, rangoX), 0, Random.Range(-rangoZ, rangoZ));
        Instantiate(prefabEnemigo, posicionAleatoria, Quaternion.identity);
    }
}

