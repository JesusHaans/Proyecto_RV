using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Drawing;

public class CamaraControlador : MonoBehaviour
{
    public GameObject camaraMono, camaraIzq, camaraDer;
    Camera mono, izquierda, derecha;

    public float separacionCamaras = 0.04f;
    public float planoCercano = 0.1f;
    public float planoLejano = 100.0f;
    public float campoVision = 60.0f;
    public float alturaPlayer = 1.5f;

    private bool esEstereo;

    // Start is called before the first frame update
    void Start()
    {
        // Definicion de la camara Monocular
        mono = camaraMono.gameObject.GetComponent<Camera>();
        mono.nearClipPlane = planoCercano;
        mono.farClipPlane = planoLejano;
        mono.fieldOfView = campoVision;

        // Definicion de la camara Binocular
        // Definicion de la camara Izquierda
        camaraIzq.transform.localPosition -= new Vector3(separacionCamaras, 0, 0);
        izquierda = camaraIzq.GetComponent<Camera>();
        izquierda.nearClipPlane = planoCercano;
        izquierda.farClipPlane = planoLejano;
        izquierda.fieldOfView = campoVision;
        
        // Definicion de la camara Derecha
        camaraDer.transform.localPosition += new Vector3(separacionCamaras, 0, 0);
        derecha = camaraDer.GetComponent<Camera>();
        derecha.nearClipPlane = planoCercano;
        derecha.farClipPlane = planoLejano;
        derecha.fieldOfView = campoVision;
        esEstereo = false;
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(esEstereo);
        camaraDer.SetActive(esEstereo);
        camaraIzq.SetActive(esEstereo);
        camaraMono.SetActive(!esEstereo);
    }

    public void CheckBoxCambio(bool valor)
    {
        esEstereo = valor;
    }
}
