using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AranaTipo1 : MonoBehaviour
{
    public Transform huevoTipo2; // Huevo de tipo 2 hacia el cual se dirigirá la araña de tipo 1
    public Transform objetivoGeneral; // Objetivo hacia el cual se moverán las arañas de tipo 1
    public float velocidad = 5f;
    private Renderer rendererAraña;
    public Mesh nuevoMesh; // Asigna el nuevo Mesh en el Inspector
    public SkinnedMeshRenderer skinnedMeshRenderer; // Asigna el Skinned Mesh Renderer en el Inspector



    private void Start()
    {
        rendererAraña = GetComponent<Renderer>(); // Para cambiar el color cuando colisione con un huevo tipo 2
    }

    private void OnEnable()
    {
        // Suscribirse al evento que ocurre cuando el cubo colisiona con arañas del grupo 1
        CuboCollision.OnAranaGrupo1Collision += MoverHaciaHuevoTipo2;
               
        // Suscribirse al evento cuando el cubo colisiona con una araña de tipo 2
        CuboCollision.OnAranaGrupo2Collision += MoverHaciaObjetivoGeneral;

    }

    private void OnDisable()
    {
        // Desuscribirse del evento cuando la araña se desactive
        CuboCollision.OnAranaGrupo1Collision -= MoverHaciaHuevoTipo2;

        // Desuscribirse del evento cuando la araña se desactive
        CuboCollision.OnAranaGrupo2Collision -= MoverHaciaObjetivoGeneral;
    }

    // Callback que se ejecuta cuando el cubo colisiona con una araña de tipo 1
    private void MoverHaciaHuevoTipo2()
    {
        Debug.Log("Araña tipo 1 moviéndose hacia el huevo tipo 2");
        StartCoroutine(MoverHaciaObjetivo(huevoTipo2.position));
    }

    private void MoverHaciaObjetivoGeneral()
    {
        Debug.Log("Araña tipo 1 moviéndose hacia el huevo tipo 2");
        StartCoroutine(MoverHaciaObjetivo(objetivoGeneral.position));
    }

    private IEnumerator MoverHaciaObjetivo(Vector3 objetivo)
    {
        while (Vector3.Distance(transform.position, objetivo) > 0.1f)
        {
            transform.position = Vector3.MoveTowards(transform.position, objetivo, velocidad * Time.deltaTime);
            yield return null;
        }
    }

    private void OnCollisionEnter(Collision collision)
{
    if (collision.gameObject.CompareTag("HuevoTipo2"))
    {
        Debug.Log("Araña colisiono!");
        if (skinnedMeshRenderer != null)
        {
            // Cambia el Mesh del Skinned Mesh Renderer
            skinnedMeshRenderer.sharedMesh = nuevoMesh; // O usa skinnedMeshRenderer.mesh para una instancia
            Debug.Log("Skinned Mesh cambiado a " + nuevoMesh.name);
        }
        else
        {
            Debug.LogWarning("No se encontró un SkinnedMeshRenderer asignado.");
        }
    }
}

}

