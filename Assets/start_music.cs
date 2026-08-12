using UnityEngine;

public class start_music : MonoBehaviour
{
    public AudioClip music;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        AudioManager.instance.PlayMusic(music);
    }
}
