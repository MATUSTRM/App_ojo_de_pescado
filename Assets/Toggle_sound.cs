using System;
using UnityEngine;
using UnityEngine.UI;

public class Toggle_sound : MonoBehaviour
{
    public enum sounds {musicSource,soundSource}

    public sounds types;
    private Button btn;
    public Sprite on;
    public Sprite off;

    private Image img_btn;
    bool value;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        img_btn = GetComponent<Image>();
        btn = GetComponent<Button>();
        btn.onClick.AddListener(toggle);
    }


    public void toggle()
    {
        switch (types)
        {
            case sounds.musicSource:
            toggle_sprite();
            toggle_music();
            break;
            
            case sounds.soundSource:
            toggle_sprite();
            toggle_sound();
            break;
        }

    }

    public void toggle_music()
    {
        AudioManager.instance.Toggle_music();
    }
    

    public void toggle_sound()
    {
        AudioManager.instance.Toggle_sound();
    }
    public void toggle_sprite()
    {
        //SI ESTA EN OFF
        if (!value)
        {
            value = !value;
            //SPRITE DEL MUTEADO
            img_btn.sprite = off;
            
        }
        //SI ESTA EN ON
        else
        {
            value = !value;
            //SPRITE DEL NO MUTEADO
            img_btn.sprite = on;
        }
    }

}
