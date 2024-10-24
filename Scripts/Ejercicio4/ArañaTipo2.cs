using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArañaTipo2 : MonoBehaviour
{
    public float velocidad = 2f; // Velocidad de movimiento
    public Transform objetoObjetivo; // Asigna el objeto objetivo en el Inspector

    public void OrientarHaciaObjetivo()
    {
        // Mueve la araña hacia el objeto objetivo
        Vector3 direccion = (objetoObjetivo.position - transform.position).normalized;
        transform.position += direccion * velocidad * Time.deltaTime; // Movimiento suave hacia el objetivo
    }
}

