using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Mostrar_actividad : MonoBehaviour
{
    public Actividad actividad;
    Button btn_actividad;
    public Panel_info panel_info;

    public TextMeshProUGUI titulo_instantanea;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        titulo_instantanea.text = actividad.Titulo;
        btn_actividad = GetComponent<Button>();
        btn_actividad.onClick.AddListener(mostrar);
    }

    public void mostrar()
    {
        panel_info.imagen.sprite = actividad.imagen;
        panel_info.titulo.text = actividad.Titulo;
        panel_info.descripcion.text = actividad.Descripcion;
        panel_info.gameObject.SetActive(true);
    }
}
