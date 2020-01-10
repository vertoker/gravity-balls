using UnityEngine;
using UnityEngine.UI;

public class Settings : MonoBehaviour
{
    public Slider musicontroller;

    public void Awake()
    {
        musicontroller.value = PlayerPrefs.GetFloat("MusicVolume");
    }

    public void Update()
    {
        PlayerPrefs.SetFloat("MusicVolume", musicontroller.value);
    }
}
