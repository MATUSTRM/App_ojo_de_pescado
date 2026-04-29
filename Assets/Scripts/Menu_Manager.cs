using UnityEngine;
using UnityEngine.UI;
public class Menu_Manager : MonoBehaviour
{
    [Header("MENUS PRINCIPAL")]
    [Tooltip("SELECCIONA EL MENU QUE NECESITAS MOSTRAR")]
    public GameObject Menu_objetivo;
    [Tooltip("SELECCIONA EL BOTON QUE HARA QUE MUESTRE EL MENU QUE ESCOGISTE")]
    public Button btn_obj;
    [Tooltip("SELECCIONA EL MENU PRINCIPAL ACA")]
    public GameObject Menu_Anterior;
    [Tooltip("SELECCIONA EL BOTON QUE HARA PARA VOLVER AL MENU PRINCIPAL")]
    public Button btn_volver;
    
    // DE MOMENTO

    /// // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        btn_obj.onClick.AddListener(mostrar_menu);
        btn_volver.onClick.AddListener(Volver_menu);
    }

  
    public void mostrar_menu()
    {
        Menu_objetivo.SetActive(true);
        Menu_Anterior.SetActive(false);
    }
    public void Volver_menu()
    {
        Menu_Anterior.SetActive(true);
        Menu_objetivo.SetActive(false);
    }

}
