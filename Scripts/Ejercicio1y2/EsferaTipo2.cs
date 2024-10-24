using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EsferaTipo2 : MonoBehaviour
{
    public Transform cilindro; // El cilindro hacia el cual se moverán las esferas de tipo 2
    public float velocidad = 5f;

    private void OnEnable()
    {
        // Suscribirse al evento cuando la esfera se active
        CylinderCollision.OnCuboCollision += MoverHaciaCilindro;
    }

    private void OnDisable()
    {
        // Desuscribirse del evento cuando la esfera se desactive
        CylinderCollision.OnCuboCollision -= MoverHaciaCilindro;
    }

    // Callback que se ejecuta cuando el cubo colisiona con el cilindro
    private void MoverHaciaCilindro()
    {
        // Aquí podemos mover la esfera hacia el cilindro
        Debug.Log("Esfera tipo 2 moviéndose hacia el cilindro");
        // Movimiento suave hacia la posición del cilindro
        StartCoroutine(MoverHaciaObjetivo());
    }

    private IEnumerator MoverHaciaObjetivo()
    {
        while (Vector3.Distance(transform.position, cilindro.position) > 0.1f)
        {
            transform.position = Vector3.MoveTowards(transform.position, cilindro.position, velocidad * Time.deltaTime);
            yield return null;
        }
    }
}
