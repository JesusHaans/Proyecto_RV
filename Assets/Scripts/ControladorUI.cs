using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Photon.Pun;

public class ControladorUI : MonoBehaviourPunCallbacks
{
    public GameObject UIPanel, UIBoton, Piel;

    // Start is called before the first frame update
    void Start()
    {
        UIPanel.SetActive(true);    
    }

    public void ActivarUI()
    {
        Debug.Log("aguacate");
        if (UIPanel.activeInHierarchy)
        {
            UIPanel.SetActive (false);
            UIBoton.GetComponentInChildren<Text>().text = "Mostrar Controles";
        }
        else
        {
            UIPanel.SetActive(true);
            UIBoton.GetComponentInChildren<Text>().text = "Ocultar Controles";
        }
    }
}
