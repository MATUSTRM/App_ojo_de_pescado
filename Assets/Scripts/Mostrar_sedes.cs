using UnityEngine;
using UnityEngine.UI;
public class Mostrar_sedes : MonoBehaviour
{
    public Dropdown Opciones;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Opciones.onValueChanged.AddListener(cambiar_sede);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void cambiar_sede(int index)
    {
        
    }
}
