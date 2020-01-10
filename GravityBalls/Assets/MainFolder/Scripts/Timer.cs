using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public GameObject isTimer;
    public GameObject isFinished;
    public Text timertext;
    public Text setText;
    public int minset;
    public int secset;
    private bool fin;
    private int min;
    private float sec;

    public void Awake()
    {
        setText.text = minset + ":" + secset + ".0";
        isTimer.SetActive(false);
        isFinished.SetActive(false);
        fin = false;
        min = 0;
        sec = 0;
    }

    public void Start()
    {
        StartCoroutine(TimerPlay());
    }

    public void Update()
    {
        if(isFinished.activeSelf == true)
        {
            if (fin == false)
            {
                fin = true;
                if ((minset * 60) + secset >= (min * 60) + sec)
                {
                    isTimer.SetActive(true);
                }
                else
                {
                    isTimer.SetActive(false);
                }
            }
        }
    }

    public IEnumerator TimerPlay()
    {
        yield return new WaitForSeconds(0.1f);
        if (isFinished.activeSelf == false)
        {
            if (sec >= 59.9f)
            {
                min = min + 1;
                sec = 0;
            }
            else
            {
                sec = sec + 0.1f;
            }
            timertext.text = min + ":" + sec.ToString("f1");
            StartCoroutine(TimerPlay());
        }
    }
}
