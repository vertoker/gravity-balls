using UnityEngine;

public class Pause : MonoBehaviour
{
    public GameObject pause;

    public void Start()
    {
        Time.timeScale = 1.0f;
    }

    public void PauseBut()
    {
        if (Time.timeScale == 1.0f)
        {
            Time.timeScale = 0f;
            pause.SetActive(true);
        }
        else
        {
            Time.timeScale = 1.0f;
            pause.SetActive(false);
        }
    }
}
