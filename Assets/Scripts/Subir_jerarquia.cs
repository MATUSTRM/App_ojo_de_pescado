using UnityEngine;
using UnityEngine.UI;

public class Subir_jerarquia : MonoBehaviour
{
    [SerializeField] private UI_OrderManager _OrderManager;
    [SerializeField] private GameObject Juego;

    private Button boton;

    void Start()
    {
        boton = GetComponent<Button>();
        boton.onClick.AddListener(() => _OrderManager.TraerAlFrente(Juego));
    }
}