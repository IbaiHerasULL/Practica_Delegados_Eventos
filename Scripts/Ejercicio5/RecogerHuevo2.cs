using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RecogerHuevo2 : MonoBehaviour
{
    public float velocidadMovimiento = 5f; // Velocidad de movimiento hacia el huevo
    private Vector3 objetivo; // Posición del huevo al que se dirige
    private bool enMovimiento = false; // Para controlar el estado de movimiento

    // Método que inicia el movimiento hacia el huevo
    public void RecogerHuevo(Vector3 posicionHuevo)
    {
        Debug.Log("Araña tipo 2 se mueve hacia el huevo.");
        objetivo = posicionHuevo; // Asigna la posición del huevo
        enMovimiento = true; // Cambia el estado a en movimiento
    }

    private void FixedUpdate()
    {
        // Mueve la araña hacia el objetivo si está en movimiento
        if (enMovimiento)
        {
            MoverHaciaObjetivo();
        }
    }

    private void MoverHaciaObjetivo()
    {
        // Mueve la araña hacia el objetivo
        transform.position = Vector3.MoveTowards(transform.position, objetivo, velocidadMovimiento * Time.deltaTime);

        // Verifica si ha alcanzado el objetivo
        if (Vector3.Distance(transform.position, objetivo) < 0.1f)
        {
            Debug.Log("Araña tipo 2 ha alcanzado el huevo.");
            enMovimiento = false; // Detiene el movimiento
        }
    }
}
