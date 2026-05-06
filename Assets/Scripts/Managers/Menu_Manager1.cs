using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Menu_Manager1 : MonoBehaviour
{
    [SerializeField] private List<ButtonInfo> buttons = new List<ButtonInfo>();

    void Start()
    {
        for (int i = 0; i < buttons.Count; i++)
        {
            ButtonInfo info = buttons[i];

            if (info.button != null && info.currentPanel != null && info.nextPanel != null)
            {
                GameObject current = info.currentPanel;
                GameObject next = info.nextPanel;

                // Opcional: log para ver a dónde va
                string destino = info.destiny_name;

                info.button.onClick.AddListener(() =>
                {
                    Debug.Log("Cambiando a: " + destino);
                    ButtonAction(current, next);
                });
            }
        }
    }

    private void ButtonAction(GameObject current, GameObject next)
    {
        current.SetActive(false);
        next.SetActive(true);
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