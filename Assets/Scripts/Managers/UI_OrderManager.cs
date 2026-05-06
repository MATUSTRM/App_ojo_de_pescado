using System.Collections.Generic;
using UnityEngine;

public class UI_OrderManager : MonoBehaviour
{
    [SerializeField] private List<GameObject> objetos = new List<GameObject>();

    // Método para traer al frente un objeto específico
    public void TraerAlFrente(GameObject obj)
    {
        if (obj == null) return;

        // Verifica que esté en la lista (opcional pero recomendado)
        if (!objetos.Contains(obj))
        {
            Debug.LogWarning("El objeto no está en la lista");
            return;
        }

        // Esto lo pone al final de la jerarquía (encima de todo)
        obj.transform.SetAsLastSibling();
    }
}