using UnityEngine;

public class AudioController : MonoBehaviour
{
    public AudioSource maintheme;
    public bool ismenu;
    private bool Lose1;

    public void Awake()
    {
        Lose1 = false;
        maintheme.pitch = 1f;
    }

    public void Update()
    {
        maintheme.volume = PlayerPrefs.GetFloat("MusicVolume");
        if (!GameObject.FindWithTag("Player") && Lose1 == false && ismenu == false)
        {
            Lose();
            Lose1 = true;
        }
    }

    public void Lose()
    {
        maintheme.pitch = 0.95f;
        maintheme.pitch = 0.9f;
        maintheme.pitch = 0.85f;
        maintheme.pitch = 0.8f;
    }
}
