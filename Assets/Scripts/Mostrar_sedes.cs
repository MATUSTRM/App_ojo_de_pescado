using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Mostrar_sedes : MonoBehaviour
{
    public TMP_Dropdown Opciones;
    public TextMeshProUGUI Text_descripcion;
    public RawImage imagen;
    public Sedes[] sedes;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Opciones.onValueChanged.AddListener(cambiar_sede);
        cambiar_sede(Opciones.value);
    }

    public void cambiar_sede(int index)
    {
        if (sedes[index] != null)
        {
            return;
        }
        if (sedes[index].Descripcion == "") 
        {
            Text_descripcion.text = sedes[index].Descripcion;
        }
        if (sedes[index].imagen_sede != null)
        {
            imagen.texture = sedes[index].imagen_sede;
        }
        // RECORRE LAS SEDES Y APAGA LAS QUE NO SE USAN
        
    }
}



