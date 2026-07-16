using UnityEngine;
using TMPro;
public class Mostrar_evento : MonoBehaviour
{
    [Tooltip("ASIGNA EL EVENTO QUE TENGAS CREADO")]
    [SerializeField]private Evento obj_evento;
    [Tooltip("ASIGNA EL TEXT MESH DEL BLOQUE QUE VAS A USAR EN EL HORARIO")]
    [Header("NOMBRE DEL EVENTO")]
    [SerializeField] Texture portada;
    
    [Header("NOMBRE DEL EVENTO")]
    
    public TextMeshProUGUI nombre;
    [Header("TEXT HORARIO")]
    public TextMeshProUGUI hora_inicio;
    public TextMeshProUGUI hora_final;

    public TextMeshProUGUI fecha;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        if (hora_final == null || hora_inicio == null || portada == null)
        {
            return;
        }
        nombre.SetText(obj_evento.nombre);

        //REFERENCIA hh:mm
        portada = obj_evento.img_evento;
        hora_inicio.text = obj_evento.h_inicio.ToString()+":" + obj_evento.m_inicio.ToString();
        hora_final.text = obj_evento.h_final.ToString()+":" + obj_evento.m_final.ToString();
        fecha.text = obj_evento.dia.ToString() +"-"+ obj_evento.mes.ToString() + "-"+obj_evento.año.ToString();
    }
}
