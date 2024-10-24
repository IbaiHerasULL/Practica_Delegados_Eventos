using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Huevo : MonoBehaviour
{
    private int puntos; // Puntos que este huevo otorga

    private void Start()
    {
        // Asignar puntos según la etiqueta del huevo
        if (CompareTag("HuevoTipo1"))
        {
            puntos = 5; // Huevo tipo 1 suma 5 puntos
        }
        else if (CompareTag("HuevoTipo2"))
        {
            puntos = 10; // Huevo tipo 2 suma 10 puntos
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        // Verificar si el objeto con el que colisionamos es una araña
        if (other.CompareTag("AranaTipo1") || other.CompareTag("AranaTipo2"))
        {
            // Obtener el controlador de juego para actualizar la puntuación
            GameController gameController = FindObjectOfType<GameController>();

            // Sumar puntos al jugador según el tipo de huevo
            gameController.AumentarPuntuacion(puntos);

            Destroy(gameObject); // Destruir el huevo después de ser recogido
        }
    }
}
