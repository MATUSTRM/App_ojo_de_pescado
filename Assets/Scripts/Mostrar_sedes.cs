using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Mostrar_sedes : MonoBehaviour
{
    public TMP_Dropdown Opciones;
    public TextMeshProUGUI Text_descripcion;
    public Image imagen;
    public Sedes[] sedes;

    public GameObject[] horarios;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Opciones.onValueChanged.AddListener(cambiar_sede);
        cambiar_sede(Opciones.value);
        Opciones.onValueChanged.AddListener(cambiar_horario);
        cambiar_horario(Opciones.value);
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
            imagen.sprite = sedes[index].imagen_sede;
        }
        else
        {
            imagen.sprite = sedes[index].imagen_sede;
        }
        

    }


    public void cambiar_horario(int index)
    {
        foreach (var horario in horarios)
        {
            //SI EL INDEX ES IGUAL AL INDICE DE HORARIOS
            if (horarios[index] != horario)
            {
                //ACTIVA EL GAMEOBJECT
                horario.SetActive(false);
            }
            else
            {
                horario.SetActive(true);
            }
        }
    }


}



