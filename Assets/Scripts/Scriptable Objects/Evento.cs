using UnityEngine;

[CreateAssetMenu(fileName = "Evento", menuName = "Scriptable Objects/Evento")]
public class Evento : ScriptableObject
{
    public string nombre;
    [Header("HORARIO")]
    public string Inicio;
    public string Final;
}
