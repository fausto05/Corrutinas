using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoverObjeto : MonoBehaviour
{
    private Vector3 posicionInicial;
    private Vector3 posicionObjetivo = new Vector3(3f, 0f, 0f);
    public float velocidad = 2f;
    public float tiempoEspera = 2f;
    void Start()
    {
        posicionInicial = transform.position;
        StartCoroutine(MoverObjetos());
    }

    IEnumerator MoverObjetos()
    {
        while (true)
        {
            while (transform.position.x < posicionObjetivo.x)
            {
                transform.position = Vector3.MoveTowards(transform.position, posicionObjetivo, velocidad * Time.deltaTime);
                yield return null;
            }

            yield return new WaitForSeconds(tiempoEspera);

            while (transform.position.x > posicionInicial.x)
            {
                transform.position = Vector3.MoveTowards(transform.position, posicionInicial, velocidad * Time.deltaTime);
                yield return null;
            }

            yield return new WaitForSeconds(tiempoEspera);
        }
        
        
    }
}

