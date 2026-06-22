using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public static AudioManager instance { get; private set; }
    [SerializeField] private AudioSource musicSource;
    [SerializeField] private AudioSource sfxSource;

    private float previousMusicVolume;
    private bool volumenReducido = false;

    private const string MUSIC_KEY = "Music_Volume";
    private const string SFX_KEY = "SFX_Volume";
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
            return;
        }
        LoadAudioSetting();
    }
    public void PlayMusic(AudioClip clip, bool loop = true)
    {
        if (musicSource.clip == clip)
        {
            if (!musicSource.isPlaying) musicSource.Play();
            return;
        }
        musicSource.clip = clip;
        musicSource.loop = loop;
        musicSource.Play();
    }

    public void PlaySFX(AudioClip clip)
    {
        sfxSource.PlayOneShot(clip);
    }
    public void LoadAudioSetting()
    {
        float musicVolume = PlayerPrefs.GetFloat(MUSIC_KEY, 0.78f);
        float sfxVolume = PlayerPrefs.GetFloat(SFX_KEY, 0.78f);
        SetMusicVolume(musicVolume);
        SetSFXVolume(sfxVolume);
        
    }
    
    public void SetMusicVolume(float volumeValue)
    {
        musicSource.volume = volumeValue;
        PlayerPrefs.SetFloat(MUSIC_KEY, volumeValue);
        PlayerPrefs.Save();
    }

    public void SetSFXVolume(float volumeValue)
    {
        sfxSource.volume = volumeValue;
        PlayerPrefs.SetFloat(SFX_KEY, volumeValue);
        PlayerPrefs.Save();
    }



    //ESTA FUNCION HARA QUE PUEDA TRANSICIONAR ENTRE BOTONES

    public void ReducirVolumenTemporal(float volumenBajo = 0.2f)
    {
        if (!volumenReducido)
        {
            previousMusicVolume = musicSource.volume;
            volumenReducido = true;
        }

        musicSource.volume = volumenBajo;
    }

    public void RestaurarVolumen()
    {
        if (volumenReducido)
        {
            musicSource.volume = previousMusicVolume;
            volumenReducido = false;
        }
    }
}
