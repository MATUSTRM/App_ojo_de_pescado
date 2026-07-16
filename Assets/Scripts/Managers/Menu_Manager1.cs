using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

    //ESTE SCRIPT SE ENCARGARA DE MANEJAR LOS FLUJO DE PANTALLA DE LOS MENUS
    //MEDIANTE LOS BOTONES Y CADA BOTON PODRA LLAMAR A UNA TRANSICION
public class Menu_Manager1 : MonoBehaviour
{
    private GameObject current;
    private GameObject next;
    [SerializeField] Animator Main_transition;
    [SerializeField] private AudioClip sfx_click;
    [SerializeField] private List<ButtonInfo> buttons = new List<ButtonInfo>();

    public static event Action on_select_button_in_menu;

    void Start()
    {
        for (int i = 0; i < buttons.Count; i++)
        {
            ButtonInfo info = buttons[i];
            
            if (info.button != null && info.currentPanel != null && info.nextPanel != null)
            {
                GameObject current = info.currentPanel;
                GameObject next = info.nextPanel;

                //AHORA NECESITO HACER QUE CADA VEZ QUE PRESIONE UN BOTON, HAYA UNA ESPERA DE CAMBIO DE MENU Y SE EJECUTE
                string destino = info.destiny_name;
                info.button.onClick.AddListener(() =>{Debug.Log("Cambiando a: " + destino);AudioManager.instance.PlaySFX(sfx_click);
                //EMITIMOS UN EVENTO PARA SUSCRIBIRNOS A UNA CLASE QUE PERMITA TRANSICIONAR ENTRE LOS DISTINTOS MENU
                StartCoroutine(ch_menu(info,current,next));
                on_select_button_in_menu.Invoke();
                });


            if (Main_transition == null)
            {
                Debug.LogWarning("MAIN TRANSITION NO ASIGNADO");
            }
            
            }
        }
    }


    private void ButtonAction(GameObject current, GameObject next)
    {
        current.SetActive(false);
        next.SetActive(true);
    }

    IEnumerator ch_menu(ButtonInfo info, GameObject current, GameObject next)
    {
        //AGREGAMOS EL DELAY QUE ASIGNAMOS AL DELAY DEL BOTON
         float delay = info.delay_time;
         //ME ES MAS COMODO HACER ENUM CON SWITCH CASE :/
         switch(info.transition)
                {
                    case ButtonInfo.transition_type.nothing:
                        //StopAllCoroutines();
                        break;
                    case ButtonInfo.transition_type.cine:
                        Main_transition.Play("cine");
                        break;
                    case ButtonInfo.transition_type.flash:
                        Main_transition.Play("flash");       
                        break;
                };
        yield return new WaitForSeconds(delay);
        ButtonAction(current,next);
        //ACA DEBERIA HACER EL CAMBIO 
    }


}
  // ACA ALMACENAREMOS LOS DATOS PARA QUE SEA MAS FACIL MANEJAR FLUJOS DE PANTALLA
[System.Serializable]
public class ButtonInfo
{
    public string destiny_name; 
    public enum transition_type {nothing,cine,flash}
    public transition_type transition;
    public Button button;

    [Range(0,5)] public float delay_time;
    public GameObject currentPanel;
    public GameObject nextPanel;
}