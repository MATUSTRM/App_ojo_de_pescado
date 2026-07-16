using UnityEngine;

public class Transition_controller : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    [SerializeField] Animator animator_transition;
    [SerializeField] bool value = false;

    public void update_transition()
    {
        animator_transition.SetBool("show",value);
    }

    void Update()
    {
        update_transition();
    }
    public void hide_transition()
    {
        value = false;
    }

    public void show_transition()
    {
        value = true;
    }

    void OnEnable()
    {
        show_transition();
        Menu_Manager1.on_select_button_in_menu += hide_transition;
    }

    void OnDisable()
    {
        Menu_Manager1.on_select_button_in_menu -= hide_transition;
    }
}
