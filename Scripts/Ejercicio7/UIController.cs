using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro; // Asegúrate de incluir el espacio de nombres para TextMeshPro

public class UIController : MonoBehaviour
{
    public static UIController Instance; // Instancia estática para acceso global
    public TextMeshProUGUI recompensaText; // Referencia al texto de recompensa

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }

    private void Start()
    {
        recompensaText.gameObject.SetActive(false); // Inicialmente oculta el texto de recompensa
    }

    public void MostrarRecompensa(int recompensa)
    {
        recompensaText.text = "¡Has obtenido una recompensa! Total: " + recompensa;
        recompensaText.gameObject.SetActive(true); // Muestra el texto de recompensa

        Invoke("OcultarRecompensa", 3f); // Oculta después de 3 segundos
    }

    private void OcultarRecompensa()
    {
        recompensaText.gameObject.SetActive(false);
    }
}

