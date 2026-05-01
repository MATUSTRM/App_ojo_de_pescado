using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Mostrar_sedes : MonoBehaviour
{
    public TMP_Dropdown Opciones;
    public GameObject [] sedes;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Opciones.onValueChanged.AddListener(cambiar_sede);
        cambiar_sede(Opciones.value);
    }

    public void cambiar_sede(int index)
    {
        // RECORRE LAS SEDES Y APAGA LAS QUE NO SE USAN
        for (int i = 0; i < sedes.Length; i++)
        {
            if (i != index)
            {
                sedes[i].SetActive(false);
            }
        }
        // SE ACTIVA LA QUE SI SE USA
        sedes[index].SetActive(true);
    }
}



