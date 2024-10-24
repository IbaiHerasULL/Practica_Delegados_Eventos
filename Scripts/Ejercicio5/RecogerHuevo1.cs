using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RecogerHuevo1 : MonoBehaviour
{
    public void RecogerHuevo(Vector3 posicionHuevo)
    {
        Debug.Log("Araña tipo 1 se teletransporta al huevo.");
        transform.position = posicionHuevo; // Teletransportar a la posición del huevo
    }
}

