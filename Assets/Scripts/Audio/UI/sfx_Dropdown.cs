using TMPro;
using UnityEngine;

public class sfx_Dropdown : MonoBehaviour
{

    private TMP_Dropdown drop_opciones;
    public AudioClip sfx;
    //REPRODUCE EL SONIDO CUANDO SE SELECCIONA UNA DE LAS OPCIONES DEL DROPDOWN
    void Start()
    {
        drop_opciones = GetComponent<TMP_Dropdown>();
        drop_opciones.onValueChanged.AddListener(play_sfx_d);
    }

    public void play_sfx_d(int index)
    {
        AudioManager.instance.PlaySFX(sfx);
    }
    
}
