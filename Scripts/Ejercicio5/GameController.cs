using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    private int puntuacion = 0; // Inicializa la puntuación
    private int recompensasObtenidas = 0; // Inicializa el contador de recompensas Ejercicio7

    public void AumentarPuntuacion(int cantidad)
    {
        puntuacion += cantidad;
        Debug.Log("Puntuación actual: " + puntuacion);
        // Comprueba si se ha alcanzado una recompensa
        if (puntuacion >= (recompensasObtenidas + 1) * 100)
        {
            Recompensa();
        }
    }

     // Método para obtener la puntuación actual Ejercicio6
    public int GetPuntuacion()
    {
        return puntuacion;
    }

    //Metodo para obtener una recompensa Ejercicio7
    private void Recompensa()
    {
        recompensasObtenidas++;
        Debug.Log("¡Recompensa obtenida! Total de recompensas: " + recompensasObtenidas);
        
        // Aquí puedes llamar a un método para mostrar la recompensa en la UI
        UIController.Instance.MostrarRecompensa(recompensasObtenidas);
    }
}

