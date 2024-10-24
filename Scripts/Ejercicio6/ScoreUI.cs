using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro; // Importa el espacio de nombres de TextMeshPro


public class ScoreUI : MonoBehaviour
{
    public TextMeshProUGUI puntuacionText; // Referencia al componente TextMeshPro
    private GameController gameController; // Referencia al controlador del juego

    private void Start()
    {
        // Encuentra el GameController en la escena
        gameController = FindObjectOfType<GameController>();
        // Inicializa el texto con la puntuación actual
        ActualizarPuntuacion();
    }

    private void Update()
    {
        ActualizarPuntuacion();
    }

    public void ActualizarPuntuacion()
    {
        // Actualiza el texto con la puntuación actual del GameController
        puntuacionText.text = "Puntuación: " + gameController.GetPuntuacion().ToString();
    }
}

