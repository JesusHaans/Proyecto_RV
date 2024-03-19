using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ControladorUI : MonoBehaviour
{
    public GameObject UIPanel, UIBoton, Piel;

    // Start is called before the first frame update
    void Start()
    {
        UIPanel.SetActive(true);    
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ActivarUI()
    {
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