using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
public class Sfxs_button : MonoBehaviour
{
    private Button boton;
    [Header("EFECTOS DE SONIDO")]
    public AudioClip Hover;
    public AudioClip click;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        boton = GetComponent<Button>();
        boton.onClick.AddListener(play_click);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void play_click()
    {
        AudioManager.instance.PlaySFX(click);
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        AudioManager.instance.PlaySFX(Hover);
    }

}
