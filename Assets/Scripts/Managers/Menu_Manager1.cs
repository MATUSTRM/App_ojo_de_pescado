using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Menu_Manager1 : MonoBehaviour
{
    private GameObject current;
    private GameObject next;
    [SerializeField] private List<ButtonInfo> buttons = new List<ButtonInfo>();
    [SerializeField] private float delay_time;

    void Start()
    {
        for (int i = 0; i < buttons.Count; i++)
        {
            ButtonInfo info = buttons[i];

            if (info.button != null && info.currentPanel != null && info.nextPanel != null)
            {
                current = info.currentPanel;
                next = info.nextPanel;

                // Opcional: log para ver a dónde va
                string destino = info.destiny_name;

                info.button.onClick.AddListener(() =>
                {
                    Debug.Log("Cambiando a: " + destino);
                    ButtonAction();
                });
            }
        }
    }


    private void ButtonAction()
    {
        current.SetActive(false);
        next.SetActive(true);
    }

    //HAY QUE TRANSICIONAR BIEN ENTRE LOS MENUS, MIENTRAS ESTE EN LA TRANSICION
    //NECESITO CREAR UN METODO SIN PARAMETRO QUE SEA PUBLICO, SE AGREGARA COMO EVENTO EN LA ANIMACION DE TRANSICIONES

    public void Next_menu()
    {
        ButtonAction();
    }
}

[System.Serializable]
public class ButtonInfo
{
    public string destiny_name; 
    public Button button;
    public GameObject currentPanel;
    public GameObject nextPanel;
}