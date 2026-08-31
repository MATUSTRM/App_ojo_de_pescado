using UnityEngine;
using UnityEngine.UI;

[CreateAssetMenu(fileName = "Actividad", menuName = "Scriptable Objects/Actividad")]
public class Actividad : ScriptableObject
{
    public Sprite imagen;
    public string Titulo;
    [TextArea]
    public string Descripcion;
}
