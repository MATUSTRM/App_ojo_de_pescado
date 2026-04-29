using UnityEngine;
using UnityEngine.UI;
public class VolumeController : MonoBehaviour
{
    [SerializeField] private Slider musicSlider;
    [SerializeField] private Slider sfxSlider;

    private float previousMusicVolume;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        if (musicSlider != null && sfxSlider != null)
        {
            musicSlider.value = PlayerPrefs.GetFloat("Music_Volume", 0.75f);
            sfxSlider.value = PlayerPrefs.GetFloat("SFX_Volume", 0.75f);

            musicSlider.onValueChanged.AddListener(SetMusicVolume);
            sfxSlider.onValueChanged.AddListener(SetsfxVolume);
        }
    }

    private void SetMusicVolume(float volume)
    {
        AudioManager.instance.SetMusicVolume(volume);
    }

    private void SetsfxVolume(float volume)
    {
        AudioManager.instance.SetSFXVolume(volume);
    }
    private void OnDestroy()
    {
        if (musicSlider != null)
        {
            musicSlider.onValueChanged.RemoveListener(SetMusicVolume);
        }
        if (sfxSlider != null)
        {
            sfxSlider.onValueChanged.RemoveListener(SetsfxVolume);
        }
    }
    
    public void volumen_trans()
    {
        AudioManager.instance.ReducirVolumenTemporal();
    }

    public void RestaurarVolumen()
    {
        AudioManager.instance.RestaurarVolumen();
    }


}
