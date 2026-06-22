using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class animation_manager : MonoBehaviour
{
    [Header("Animator Controller")]
    [Tooltip("ASIGNA EL ANIMATOR CONTROLLER BASE DONDE ESTA TODA LAS ANIMACIONES")]
    public RuntimeAnimatorController base_controller;

    [SerializeField]
    List<Button_choose> btn_animations =
        new List<Button_choose>();

    void Start()
    {
        for (int i = 0; i < btn_animations.Count; i++)
        {
            Button_choose btn_selected =
                btn_animations[i];

            // AGREGANDO EL ANIMATOR AL GAMEOBJECT VISUAL
            Animator animator =
                btn_selected.visual.gameObject
                .AddComponent<Animator>();

            animator.runtimeAnimatorController =
                base_controller;

            // CLICK
            btn_selected.button.onClick.AddListener(() =>
            {
                animator.Play(
                    btn_selected.click_animation.ToString());
            });

            // EVENT TRIGGER
            EventTrigger trigger =
                btn_selected.button.gameObject
                .GetComponent<EventTrigger>();

            if (trigger == null)
            {
                trigger =
                    btn_selected.button.gameObject
                    .AddComponent<EventTrigger>();
            }

            // HOVER ENTER
            EventTrigger.Entry hover_enter =
                new EventTrigger.Entry();

            hover_enter.eventID =
                EventTriggerType.PointerEnter;

            hover_enter.callback.AddListener((data) =>
            {
                animator.Play(
                    btn_selected.hover_animation.ToString());
            });

            trigger.triggers.Add(hover_enter);

            // HOVER EXIT
            EventTrigger.Entry hover_exit =
                new EventTrigger.Entry();

            hover_exit.eventID =
                EventTriggerType.PointerExit;

            hover_exit.callback.AddListener((data) =>
            {
                animator.Play(
                    btn_selected.hover_exit_animation.ToString());
            });

            trigger.triggers.Add(hover_exit);
        }
    }
}

public enum animations
{
    None,

    Bubble_Hover,
    Bubble_Exit,
    Bubble_Click,

    Zoom_Hover,
    Zoom_Exit,
    Zoom_Click,

    Shake_Hover,
    Shake_Exit,
    Shake_Click,

    Rotate_Hover,
    Rotate_Exit,
    Rotate_Click
}

[System.Serializable]
public class Button_choose
{
    [Header("Button")]
    public string Name_button;

    public Button button;
    [Tooltip("Asigna el VISUAL del boton que seleccionaste, ASEGURATE de que lo cambiaste")]
    [Header("Visual")]
    public Transform visual;

    [Header("Hover Animation")]
    public animations hover_animation;

    [Header("Hover Exit Animation")]
    public animations hover_exit_animation;

    [Header("Click Animation")]
    public animations click_animation;
}