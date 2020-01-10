using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using System.Collections;

public class SettingsMenu : MonoBehaviour
{
    public Swipe swipecontroller;
    public Slider musicontroller;
    public GameObject objdeleteall;
    private int swipe;
    public GameObject swipetext;
    public GameObject swipeRight;
    public GameObject swipeUp;
    public GameObject swipeLeft;
    public GameObject swipeDown;
    public GameObject bye;
    public GameObject close;

    public void Awake()
    {
        close.SetActive(true);
        swipetext.SetActive(false);
        objdeleteall.SetActive(false);
        swipeRight.SetActive(false);
        swipeUp.SetActive(false);
        swipeLeft.SetActive(false);
        swipeDown.SetActive(false);
        bye.SetActive(false);
        swipe = 0;
    }

    public void Start()
    {
        musicontroller.value = PlayerPrefs.GetFloat("MusicVolume");
    }

    public void DeleteAllOpen()
    {
        swipeRight.SetActive(true);
        swipetext.SetActive(true);
        objdeleteall.SetActive(true);
        swipe = 1;
    }

    public void Update()
    {
        PlayerPrefs.SetFloat("MusicVolume", musicontroller.value);

        switch (swipe)
        {
            case 1:
                if (swipecontroller.SwipeRight)
                {
                    swipeRight.SetActive(false);
                    swipeUp.SetActive(true);
                    swipe = 2;
                }
                break;
            case 2:
                if (swipecontroller.SwipeUp)
                {
                    swipeUp.SetActive(false);
                    swipeLeft.SetActive(true);
                    swipe = 3;
                }
                break;
            case 3:
                if (swipecontroller.SwipeLeft)
                {
                    swipeLeft.SetActive(false);
                    swipeDown.SetActive(true);
                    swipe = 4;
                }
                break;
            case 4:
                if (swipecontroller.SwipeDown)
                {
                    swipetext.SetActive(false);
                    swipeDown.SetActive(false);
                    bye.SetActive(true);
                    close.SetActive(false);
                    swipe = 5;
                }
                break;
            case 5:
                StartCoroutine(DeleteAll());
                break;
        }
    }

    public IEnumerator DeleteAll()
    {
        yield return new WaitForSeconds(0.5f);
        SceneManager.LoadScene(0);
        PlayerPrefs.SetInt("Losses", 0);
        PlayerPrefs.SetInt("lv1", 1);
        PlayerPrefs.SetInt("lv2", 0);
        PlayerPrefs.SetInt("lv3", 0);
        PlayerPrefs.SetInt("lv4", 0);
        PlayerPrefs.SetInt("lv5", 0);
        PlayerPrefs.SetInt("lv6", 0);
        PlayerPrefs.SetInt("lv7", 0);
        PlayerPrefs.SetInt("lv8", 0);
        PlayerPrefs.SetInt("lv9", 0);
        PlayerPrefs.SetInt("lv10", 0);
        PlayerPrefs.SetInt("lv11", 0);
        PlayerPrefs.SetInt("lv12", 0);
        PlayerPrefs.SetInt("lv13", 0);
        PlayerPrefs.SetInt("lv14", 0);
        PlayerPrefs.SetInt("lv15", 0);
        PlayerPrefs.SetInt("lv16", 0);
        PlayerPrefs.SetInt("lv17", 0);
        PlayerPrefs.SetInt("lv18", 0);
        PlayerPrefs.SetInt("lv19", 0);
        PlayerPrefs.SetInt("lv20", 0);
        PlayerPrefs.SetInt("lv21", 0);
        PlayerPrefs.SetInt("lv22", 0);
        PlayerPrefs.SetInt("lv23", 0);
        PlayerPrefs.SetInt("lv24", 0);
        PlayerPrefs.SetInt("lv25", 0);
        PlayerPrefs.SetInt("lv26", 0);
        PlayerPrefs.SetInt("lv27", 0);
        PlayerPrefs.SetInt("lv28", 0);
        PlayerPrefs.SetInt("lv29", 0);
        PlayerPrefs.SetInt("lv30", 0);
        PlayerPrefs.SetInt("lv31", 0);
        PlayerPrefs.SetInt("lv32", 0);
        PlayerPrefs.SetInt("lv33", 1);
        PlayerPrefs.SetInt("lv34", 0);
        PlayerPrefs.SetInt("lv35", 0);
        PlayerPrefs.SetInt("lv36", 0);
        PlayerPrefs.SetInt("lv37", 0);
        PlayerPrefs.SetInt("lv38", 0);
        PlayerPrefs.SetInt("lv39", 0);
        PlayerPrefs.SetInt("lv40", 0);
        PlayerPrefs.SetInt("lv41", 0);
        PlayerPrefs.SetInt("lv42", 0);
        PlayerPrefs.SetInt("lv43", 0);
        PlayerPrefs.SetInt("lv44", 0);
        PlayerPrefs.SetInt("lv45", 0);
        PlayerPrefs.SetInt("lv46", 0);
        PlayerPrefs.SetInt("lv47", 0);
        PlayerPrefs.SetInt("lv48", 0);
        PlayerPrefs.SetInt("lv49", 0);
        PlayerPrefs.SetInt("lv50", 0);
        PlayerPrefs.SetInt("lv51", 0);
        PlayerPrefs.SetInt("lv52", 0);
        PlayerPrefs.SetInt("lv53", 0);
        PlayerPrefs.SetInt("lv54", 0);
        PlayerPrefs.SetInt("lv55", 0);
        PlayerPrefs.SetInt("lv56", 0);
        PlayerPrefs.SetInt("lv57", 0);
        PlayerPrefs.SetInt("lv58", 0);
        PlayerPrefs.SetInt("lv59", 0);
        PlayerPrefs.SetInt("lv60", 0);
        PlayerPrefs.SetInt("lv61", 0);
        PlayerPrefs.SetInt("lv62", 0);
        PlayerPrefs.SetInt("lv63", 0);
        PlayerPrefs.SetInt("lv64", 0);
        PlayerPrefs.SetInt("lv65", 1);
        PlayerPrefs.SetInt("lv66", 0);
        PlayerPrefs.SetInt("lv67", 0);
        PlayerPrefs.SetInt("lv68", 0);
        PlayerPrefs.SetInt("lv69", 0);
        PlayerPrefs.SetInt("lv70", 0);
        PlayerPrefs.SetInt("lv71", 0);
        PlayerPrefs.SetInt("lv72", 0);
        PlayerPrefs.SetInt("lv73", 0);
        PlayerPrefs.SetInt("lv74", 0);
        PlayerPrefs.SetInt("lv75", 0);
        PlayerPrefs.SetInt("lv76", 0);
        PlayerPrefs.SetInt("lv77", 0);
        PlayerPrefs.SetInt("lv78", 0);
        PlayerPrefs.SetInt("lv79", 0);
        PlayerPrefs.SetInt("lv80", 0);
        PlayerPrefs.SetInt("lv81", 0);
        PlayerPrefs.SetInt("lv82", 0);
        PlayerPrefs.SetInt("lv83", 0);
        PlayerPrefs.SetInt("lv84", 0);
        PlayerPrefs.SetInt("lv85", 0);
        PlayerPrefs.SetInt("lv86", 0);
        PlayerPrefs.SetInt("lv87", 0);
        PlayerPrefs.SetInt("lv88", 0);
        PlayerPrefs.SetInt("lv89", 0);
        PlayerPrefs.SetInt("lv90", 0);
        PlayerPrefs.SetInt("lv91", 0);
        PlayerPrefs.SetInt("lv92", 0);
        PlayerPrefs.SetInt("lv93", 0);
        PlayerPrefs.SetInt("lv94", 0);
        PlayerPrefs.SetInt("lv95", 0);
        PlayerPrefs.SetInt("lv96", 0);
        PlayerPrefs.SetInt("lv97", 0);
        PlayerPrefs.SetInt("lv98", 0);
        PlayerPrefs.SetInt("lv99", 0);
        PlayerPrefs.SetInt("lv100", 0);
    }
}
