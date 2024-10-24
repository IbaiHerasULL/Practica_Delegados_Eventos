using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EsferaTipo1 : MonoBehaviour
{
    public Transform objetivoEsferaTipo2; // Esfera tipo 2 hacia la cual se dirigirá la esfera de tipo 1
    public float velocidad = 5f;

    private void OnEnable()
    {
        // Suscribirse al evento cuando la esfera se active
        CylinderCollision.OnCuboCollision += MoverHaciaEsferaTipo2;
    }

    private void OnDisable()
    {
        // Desuscribirse del evento cuando la esfera se desactive
        CylinderCollision.OnCuboCollision -= MoverHaciaEsferaTipo2;
    }

    // Callback que se ejecuta cuando el cubo colisiona con el cilindro
    private void MoverHaciaEsferaTipo2()
    {
        // Aquí podemos mover la esfera hacia la esfera de tipo 2 objetivo
        Debug.Log("Esfera tipo 1 moviéndose hacia la esfera tipo 2");
        // Movimiento suave hacia la posición de la esfera tipo 2
        StartCoroutine(MoverHaciaObjetivo());
    }

    private IEnumerator MoverHaciaObjetivo()
    {
        while (Vector3.Distance(transform.position, objetivoEsferaTipo2.position) > 0.1f)
        {
            transform.position = Vector3.MoveTowards(transform.position, objetivoEsferaTipo2.position, velocidad * Time.deltaTime);
            yield return null;
        }
    }
}
