using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Temporizador : MonoBehaviour
{
    public int tiempoInicial = 10;
    public Text textoTemporizador;
    public float tiempoEspera = 2f;
    void Start()
    {
        StartCoroutine(ContarRegresivamente());
    }
    
    IEnumerator ContarRegresivamente()
    {
        for (int tiempoRestante = tiempoInicial; tiempoRestante >= 0; tiempoRestante--)
        {
            Debug.Log(tiempoRestante); 

            if (textoTemporizador != null)
            {
                textoTemporizador.text = tiempoRestante.ToString();
            }

            yield return new WaitForSeconds(tiempoEspera);
        }

        Debug.Log("¡Tiempo terminado!");
    }
}
