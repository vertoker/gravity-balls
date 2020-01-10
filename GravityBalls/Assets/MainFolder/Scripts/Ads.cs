using UnityEngine;
//using UnityEngine.Advertisements;

public class Ads : MonoBehaviour
{
    public void Awake()
    {
        //if (Advertisement.isSupported)
        //{
        //    if (Advertisement.isInitialized == false)
        //    {
        //        Advertisement.Initialize("1739571", true);
        //    }
        //}
    }

    public void AdsVoid()
    {
        PlayerPrefs.SetInt("AdsShow", PlayerPrefs.GetInt("AdsShow") - 1);
    }

    public void Update()
    {
        if (PlayerPrefs.GetInt("AdsShow") == 0)
        {
            //Advertisement.Show();
            switch (PlayerPrefs.GetInt("AdsShow123"))
            {
                case 1:
                    PlayerPrefs.SetInt("AdsShow", 5);
                    PlayerPrefs.SetInt("AdsShow123", 2);
                    break;
                case 2:
                    PlayerPrefs.SetInt("AdsShow", 10);
                    PlayerPrefs.SetInt("AdsShow123", 3);
                    break;
                case 3:
                    PlayerPrefs.SetInt("AdsShow", 10);
                    break;
            }
        }
    }
}