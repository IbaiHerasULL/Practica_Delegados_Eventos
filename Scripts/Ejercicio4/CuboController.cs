using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CuboController : MonoBehaviour
{
    public Transform huevoObjetivo; // Asigna el huevo objetivo en el Inspector

    // Este método se llama cuando el cubo entra en el trigger del cilindro
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Cilindro")) // Asegúrate de que el cilindro tenga esta etiqueta
        {
            // Llamar a las funciones de las arañas del grupo 1
            ArañaTipo1[] arañasTipo1 = FindObjectsOfType<ArañaTipo1>();
            foreach (var araña in arañasTipo1)
            {
                araña.TeletransportarA(huevoObjetivo.position);
            }

            // Llamar a las funciones de las arañas del grupo 2
            ArañaTipo2[] arañasTipo2 = FindObjectsOfType<ArañaTipo2>();
            foreach (var araña in arañasTipo2)
            {
                araña.OrientarHaciaObjetivo(); // Asignar el objeto de orientación
            }
        }
    }
}

