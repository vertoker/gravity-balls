using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartGame : MonoBehaviour
{
    public bool isPlay = true;

    public void Start()
    {
        if (isPlay == true)
        {
            StartCoroutine(StartGame1sec());
        }
    }

    public IEnumerator StartGame1sec()
    {
        yield return new WaitForSeconds(1.5f);
        PlayerPrefs.SetInt("AdsShow123", 1);
        SceneManager.LoadScene(1);
        StartCoroutine(StartGame1sec());
    }
}
