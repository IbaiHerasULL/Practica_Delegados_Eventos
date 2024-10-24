using UnityEngine;
using System;

public class CylinderCollision : MonoBehaviour
{
    // Evento que se disparará al colisionar con el cubo
    public static event Action OnCuboCollision;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Cubo"))
        {
            // Llamar al evento que indica que el cubo colisionó con el cilindro
            Debug.Log("Cubo ha colisionado con el cilindro");
            OnCuboCollision?.Invoke(); // Dispara el evento
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Cubo"))
        {
            // Llamar al evento que indica que el cubo colisionó con el cilindro
            Debug.Log("Cubo ha colisionado con el cilindro");
            OnCuboCollision?.Invoke(); // Dispara el evento
        }
    }
}
