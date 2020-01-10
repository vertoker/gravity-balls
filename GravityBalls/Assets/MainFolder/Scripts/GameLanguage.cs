using UnityEngine;
using UnityEngine.UI;

public class GameLanguage : MonoBehaviour
{
    public Text failed;
    public Text music;
    public bool levelquestions;
    public bool resetlevel;

    public GameObject questionsobj;
    public GameObject resetobj;
    public Text questionstext;

    [Header("QuestionLanguage")]
    [TextArea]
    public string qEnglish; //Английский
    [TextArea]
    public string qRussian; //Русский
    [TextArea]
    public string qSpanish; //Испанский
    [TextArea]
    public string qFrench; //Французкий
    [TextArea]
    public string qItalian; //Итальянский
    [TextArea]
    public string qPolish; //Польский
    [TextArea]
    public string qTurkish; //Турецкий
    [TextArea]
    public string qJapanese; //Японский
    [TextArea]
    public string qChinese; //Китайский
    [TextArea]
    public string qKorean; //Корейский
    [TextArea]
    public string qBengali; //Бенгальский
    [TextArea]
    public string qHungarian; //Венгерский
    [TextArea]
    public string qVietnamese; //Вьетнамский
    [TextArea]
    public string qMalay; //Малайский
    [TextArea]
    public string qGerman; //Немецкий
    [TextArea]
    public string qDutch; //Нидерландский
    [TextArea]
    public string qPortuguese; //Португальский
    [TextArea]
    public string qHindi; //Хинди

    public void Awake()
    {
        questionstext.text = "";
        questionsobj.SetActive(false);
        resetobj.SetActive(false);
        SetLanguage();
    }

    public void SetLanguage()
    {
        if (resetlevel == true)
        {
            resetobj.SetActive(true);
        }

        switch (PlayerPrefs.GetInt("Language"))
        {
            case 0: //Английский
                failed.text = "You Lose";
                music.text = "Music";
                if (levelquestions == true)
                {
                    questionsobj.SetActive(true);
                    questionstext.text = qEnglish;
                }
                break;
            case 1: //Русский
                failed.text = "Проигрыш";
                music.text = "Музыка";
                if (levelquestions == true)
                {
                    questionsobj.SetActive(true);
                    questionstext.text = qRussian;
                }
                break;
            case 2: //Испанский
                failed.text = "Tú pierdes";
                music.text = "Música";
                if (levelquestions == true)
                {
                    questionsobj.SetActive(true);
                    questionstext.text = qSpanish;
                }
                break;
            case 3: //Французкий
                failed.text = "Tu as perdu";
                music.text = "La musique";
                if (levelquestions == true)
                {
                    questionsobj.SetActive(true);
                    questionstext.text = qFrench;
                }
                break;
            case 4: //Итальянский
                failed.text = "Hai perso";
                music.text = "Musica";
                if (levelquestions == true)
                {
                    questionsobj.SetActive(true);
                    questionstext.text = qItalian;
                }
                break;
            case 5: //Польский
                failed.text = "Przegrałeś";
                music.text = "Muzyka";
                if (levelquestions == true)
                {
                    questionsobj.SetActive(true);
                    questionstext.text = qPolish;
                }
                break;
            case 6: //Турецкий
                failed.text = "Kaybettin";
                music.text = "Müzik";
                if (levelquestions == true)
                {
                    questionsobj.SetActive(true);
                    questionstext.text = qTurkish;
                }
                break;
            case 7: //Японский
                failed.text = "あなたは失う";
                music.text = "音楽";
                if (levelquestions == true)
                {
                    questionsobj.SetActive(true);
                    questionstext.text = qJapanese;
                }
                break;
            case 8: //Китайский
                failed.text = "你輸了";
                music.text = "音樂";
                if (levelquestions == true)
                {
                    questionsobj.SetActive(true);
                    questionstext.text = qChinese;
                }
                break;
            case 9: //Корейский
                failed.text = "너 잃는다.";
                music.text = "음악";
                if (levelquestions == true)
                {
                    questionsobj.SetActive(true);
                    questionstext.text = qKorean;
                }
                break;
            case 10: //Бенгальский
                failed.text = "তুমি হেরেছ";
                music.text = "সঙ্গীত";
                if (levelquestions == true)
                {
                    questionsobj.SetActive(true);
                    questionstext.text = qBengali;
                }
                break;
            case 11: //Венгерский
                failed.text = "Vesztesz";
                music.text = "Zene";
                if (levelquestions == true)
                {
                    questionsobj.SetActive(true);
                    questionstext.text = qHungarian;
                }
                break;
            case 12: //Вьетнамский
                failed.text = "Bạn đã thua";
                music.text = "Âm nhạc";
                if (levelquestions == true)
                {
                    questionsobj.SetActive(true);
                    questionstext.text = qVietnamese;
                }
                break;
            case 13: //Малайский
                failed.text = "Awak kalah";
                music.text = "Muzik";
                if (levelquestions == true)
                {
                    questionsobj.SetActive(true);
                    questionstext.text = qMalay;
                }
                break;
            case 14: //Немецкий
                failed.text = "Du verlierst";
                music.text = "Musik";
                if (levelquestions == true)
                {
                    questionsobj.SetActive(true);
                    questionstext.text = qGerman;
                }
                break;
            case 15: //Нидерландский
                failed.text = "Jij verliest";
                music.text = "Muziek";
                if (levelquestions == true)
                {
                    questionsobj.SetActive(true);
                    questionstext.text = qDutch;
                }
                break;
            case 16: //Португальский
                failed.text = "Você perdeu";
                music.text = "Música";
                if (levelquestions == true)
                {
                    questionsobj.SetActive(true);
                    questionstext.text = qPortuguese;
                }
                break;
            case 17: //Хинди
                failed.text = "तुम हारे";
                music.text = "संगीत";
                if (levelquestions == true)
                {
                    questionsobj.SetActive(true);
                    questionstext.text = qHindi;
                }
                break;
        }
    }
}
