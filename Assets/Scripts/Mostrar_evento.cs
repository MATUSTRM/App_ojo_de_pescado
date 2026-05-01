using UnityEngine;
using TMPro;
public class Mostrar_evento : MonoBehaviour
{
    [Tooltip("ASIGNA EL EVENTO QUE TENGAS CREADO")]
    [SerializeField]private Evento obj_evento;
    [Tooltip("ASIGNA EL TEXT MESH DEL BLOQUE QUE VAS A USAR EN EL HORARIO")]
    public TextMeshProUGUI textmesh;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        textmesh.SetText(obj_evento.nombre);
    }
}
