using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArañaTipo1 : MonoBehaviour
{
    public void TeletransportarA(Vector3 posicionDestino)
    {
        transform.position = posicionDestino; // Teletransportar a la nueva posición
        Debug.Log($"{gameObject.name} se ha teletransportado a {posicionDestino}");
    }
}

