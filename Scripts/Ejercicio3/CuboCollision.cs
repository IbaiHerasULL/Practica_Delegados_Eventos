using UnityEngine;
using System;

public class CuboCollision : MonoBehaviour
{
    // Eventos para las colisiones con arañas de diferentes grupos
    public static event Action OnAranaGrupo1Collision;
    public static event Action OnAranaGrupo2Collision;

    private void OnCollisionEnter(Collision collision)
    {
         Debug.Log("Colisión detectada!");
        if (collision.gameObject.CompareTag("AranaTipo1"))
        {
            // Disparar el evento cuando el cubo colisiona con una araña de tipo 1
            Debug.Log("Cubo colisionó con araña de tipo 1");
            OnAranaGrupo1Collision?.Invoke();
        }

        if (collision.gameObject.CompareTag("AranaTipo2"))
        {
            // Disparar el evento cuando el cubo colisiona con una araña de tipo 2
            Debug.Log("Cubo colisionó con araña de tipo 2");
            OnAranaGrupo2Collision?.Invoke();
        }
    }
}

