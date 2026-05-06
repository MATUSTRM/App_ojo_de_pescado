using UnityEngine;

[CreateAssetMenu(fileName = "Evento", menuName = "Scriptable Objects/Evento")]
public class Evento : ScriptableObject
{
    public string nombre;
    public string Descripcion;
    public string fecha;
    [Header("HORARIO")]
    public string Inicio;
    public string Final;
}
