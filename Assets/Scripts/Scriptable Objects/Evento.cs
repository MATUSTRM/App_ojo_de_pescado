using System;
using UnityEngine;

[CreateAssetMenu(fileName = "Evento", menuName = "Scriptable Objects/Evento")]
public class Evento : ScriptableObject
{
    public enum meses {enero,febrero,marzo,abril,mayo,junio,julio,agosto,septiembre,octubre,noviembre,diciembre}
    public Texture img_evento;
    public string nombre;
    public string Descripcion;
    //MES CON ENUM

    [Header("FECHA")]
    public meses mes; 
    [Range(0,31)]public int dia;

    [Range(2026,2040)] public int año;

    [Header("HORA INICIO")]
    [Range(0,23)]public int h_inicio;
    [Range(0,59)]public int m_inicio;

    [Header("HORA FINAL")]

    [Range(0,23)]public int h_final;
    [Range(0,59)]public int m_final;
}
