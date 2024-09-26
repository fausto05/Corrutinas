using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CambiarTamaño : MonoBehaviour
{
    public float intervalo = 1f;
    void Start()
    {
        StartCoroutine(CambiarTamanoObjeto());
    }

    IEnumerator CambiarTamanoObjeto()
    {
        while (true)
        {
            float tamanoAleatorio = Random.Range(0.5f, 3f);
            transform.localScale = new Vector3(tamanoAleatorio, tamanoAleatorio, tamanoAleatorio);

            yield return new WaitForSeconds(intervalo);

        }
    }
}
