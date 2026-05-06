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
        if (sedes[index] == null)
        {
            return;
        }
        //OBTENEMOS LA INFORMACION DE LA SEDE MEDIANTE SU SCRIPTABLE OBJECT
        if (sedes[index].Descripcion == "") 
        {
            Text_descripcion.text = sedes[index].Descripcion;
        }
        else
        {
            Text_descripcion.text = sedes[index].Descripcion;
        }
        //OBTENEMOS LA IMAGEN DE LA SEDE MEDIANTE EL MISMO SCRIPTABLE OBJECT
        if (sedes[index].imagen_sede != null)
        {
            imagen.texture = sedes[index].imagen_sede;
        }
        else
        {
            imagen.texture = sedes[index].imagen_sede;
        }
        

    }
}



