using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{
    [Header("In")]
    public int IDScene;
    public int IntTrans;
    [Header("Main CPU")]
    public bool DeleteNothing;
    public float DeleteNothingTime;
    [Header("Out")]
    public GameObject Trans;
    public GameObject isFinished;
    public GameObject isTimer;
    public GameObject isStar;
    public GameObject Star1;
    public GameObject Star2;
    public GameObject Star3;
    [Header("Navigate")]
    public GameObject EndGameFailed;
    public GameObject EndGameWinner;
    public GameObject isWin;
    public GameObject isLose;
    public GameObject Pause;
    public GameObject Settings;
    private string comand =
    "LiMiDyFy@gmail.com: VertogPro - Main Developer, Logatron and Sheogarath Wend - Level Designer";

    public void Awake()
    {
        Trans.name = IntTrans.ToString();
        EndGameFailed.SetActive(false);
        EndGameWinner.SetActive(false);
        isStar.SetActive(false);
        isTimer.SetActive(false);
        isFinished.SetActive(false);
        if (DeleteNothingTime == 0f) { DeleteNothingTime = 0.1f; }
        if (DeleteNothing == true) { StartCoroutine(DeleteNothingIEnumerator()); }
    }

    public void Start()
    {
        StartCoroutine(FinishedEnumerator());
    }

    public void Update()
    {
        if (isWin.activeSelf == true)
        {
            EndGameWinner.SetActive(true);
            isLose.SetActive(false);
            isWin.SetActive(false);
        }
        if (isLose.activeSelf == true)
        {
            EndGameFailed.SetActive(true);
            isWin.SetActive(false);
            isLose.SetActive(false);
        }
    }

    public IEnumerator FinishedEnumerator()
    {
        yield return new WaitForSeconds(0.05f);
        if ((isFinished.activeSelf == true) && (GameObject.FindWithTag("Player")))
        {
            StartCoroutine(Finished());
        }
        else
        {
            StartCoroutine(FinishedEnumerator());
        }
    }

    public void Navigate(int n)
    {
        switch (n)
        {
            case 1:
                Settings.SetActive(true);
                break;
            case 2:
                Settings.SetActive(false);
                break;
            case 3:
                SceneManager.LoadScene(IDScene + 1);
                break;
            case 4:
                SceneManager.LoadScene(IDScene + 2);
                break;
            case 5:
                SceneManager.LoadScene(1);
                break;
        }
    }

    public IEnumerator DeleteNothingIEnumerator()
    {
        yield return new WaitForSeconds(DeleteNothingTime);
        Destroy(GameObject.FindWithTag("Nothing"));
        StartCoroutine(DeleteNothingIEnumerator());
    }

    public IEnumerator Finished()
    {
        yield return new WaitForSeconds(0.5f);
        if (PlayerPrefs.GetInt("lv" + (IDScene + 1)) == 0)
        { PlayerPrefs.SetInt("lv" + (IDScene + 1), 1); }

        #region Math Finish
        Time.timeScale = 0f;

        switch (PlayerPrefs.GetInt("lv" + IDScene))
        {
            case 1:
                if (isStar.activeSelf == true)
                {
                    PlayerPrefs.SetInt("lv" + IDScene, 3);
                    if (isTimer.activeSelf == true)
                    {
                        PlayerPrefs.SetInt("lv" + IDScene, 5);
                    }
                }
                else if (isTimer.activeSelf == true)
                {
                    PlayerPrefs.SetInt("lv" + IDScene, 4);
                }
                else
                {
                    PlayerPrefs.SetInt("lv" + IDScene, 2);
                }
                break;
            case 2:
                if (isStar.activeSelf == true)
                {
                    PlayerPrefs.SetInt("lv" + IDScene, 3);
                    if (isTimer.activeSelf == true)
                    {
                        PlayerPrefs.SetInt("lv" + IDScene, 5);
                    }
                }
                else if (isTimer.activeSelf == true)
                {
                    PlayerPrefs.SetInt("lv" + IDScene, 4);
                }
                else
                {
                    PlayerPrefs.SetInt("lv" + IDScene, 2);
                }
                break;
            case 3:
                if (isTimer.activeSelf == true)
                {
                    PlayerPrefs.SetInt("lv" + IDScene, 5);
                }
                else
                {
                    PlayerPrefs.SetInt("lv" + IDScene, 3);
                }
                break;
            case 4:
                if (isStar.activeSelf == true)
                {
                    PlayerPrefs.SetInt("lv" + IDScene, 5);
                }
                else
                {
                    PlayerPrefs.SetInt("lv" + IDScene, 4);
                }
                break;
            case 5:
                PlayerPrefs.SetInt("lv" + IDScene, 5);
                break;
        }

        if (PlayerPrefs.GetInt("lv100") >= 2)
        { PlayerPrefs.SetString("Start", comand); }

        if (isStar.activeSelf == true)
        {
            if (isTimer.activeSelf == true)
            {
                Star1.SetActive(true);
                Star2.SetActive(true);
                Star3.SetActive(true);
            }
            else
            {
                Star1.SetActive(true);
                Star2.SetActive(true);
                Star3.SetActive(false);
            }
        }
        else
        {
            if (isTimer.activeSelf == true)
            {
                Star1.SetActive(true);
                Star2.SetActive(false);
                Star3.SetActive(true);
            }
            else
            {
                Star1.SetActive(true);
                Star2.SetActive(false);
                Star3.SetActive(false);
            }
        }
        #endregion
    }
}
