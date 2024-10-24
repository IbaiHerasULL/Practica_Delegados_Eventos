using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cubo : MonoBehaviour
{
    private Huevo huevoColisionado;

    private void OnTriggerEnter(Collider other)
    {
        // Verificar si el objeto con el que colisionamos es un huevo tipo 1 o tipo 2
        if (other.CompareTag("HuevoTipo1") || other.CompareTag("HuevoTipo2"))
        {
            huevoColisionado = other.GetComponent<Huevo>();
            Debug.Log("Cubo ha colisionado con un huevo de tipo: " + other.tag);

            // Notificar a las arañas dependiendo del tipo de huevo
            NotificarAranas(other.tag);
        }
    }

    private void NotificarAranas(string tipoHuevoTag)
    {
        if (tipoHuevoTag == "HuevoTipo1")
        {
            RecogerHuevo1[] RecogerHuevo1 = FindObjectsOfType<RecogerHuevo1>();
            foreach (RecogerHuevo1 araña in RecogerHuevo1)
            {
                araña.RecogerHuevo(huevoColisionado.transform.position); // Teletransportar a la posición del huevo
            }
        }
        else if (tipoHuevoTag == "HuevoTipo2")
        {
            RecogerHuevo2[] RecogerHuevo2 = FindObjectsOfType<RecogerHuevo2>();
            foreach (RecogerHuevo2 araña in RecogerHuevo2)
            {
                araña.RecogerHuevo(huevoColisionado.transform.position); // Mover hacia el huevo
            }
        }
    }

    private void OnTriggerExit(Collider other)
    {
        // Limpiar la referencia cuando el cubo salga del huevo
        if (other.CompareTag("HuevoTipo1") || other.CompareTag("HuevoTipo2"))
        {
            huevoColisionado = null;
            Debug.Log("Cubo ha salido del huevo.");
        }
    }
}

