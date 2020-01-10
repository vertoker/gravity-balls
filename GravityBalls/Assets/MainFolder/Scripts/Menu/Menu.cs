using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

#if UNITY_EDITOR
using UnityEditor;
#endif

public class Menu : MonoBehaviour
{
    public LanguageMenu languageMenu;
    public GameObject textobj;
    public Text text;
    [Header("Menu")]
    public GameObject startobj;
    public GameObject optionsobj;
    public GameObject exitobj;
    public GameObject DeleteAll;
    public GameObject LanguageStartSelected;
    public GameObject QRCodeobj;
    public GameObject QRCodeobj2;
    public GameObject selectlanguage;
    public GameObject QRImage;
    public GameObject BonusLevel;
    [Header("Game Lock")]
    #region Game Lock
    public GameObject lock2;
    public GameObject lock3;
    public GameObject lock4;
    public GameObject lock5;
    public GameObject lock6;
    public GameObject lock7;
    public GameObject lock8;
    public GameObject lock9;
    public GameObject lock10;
    public GameObject lock11;
    public GameObject lock12;
    public GameObject lock13;
    public GameObject lock14;
    public GameObject lock15;
    public GameObject lock16;
    public GameObject lock17;
    public GameObject lock18;
    public GameObject lock19;
    public GameObject lock20;
    public GameObject lock21;
    public GameObject lock22;
    public GameObject lock23;
    public GameObject lock24;
    public GameObject lock25;
    public GameObject lock26;
    public GameObject lock27;
    public GameObject lock28;
    public GameObject lock29;
    public GameObject lock30;
    public GameObject lock31;
    public GameObject lock32;
    public GameObject lock33;
    public GameObject lock34;
    public GameObject lock35;
    public GameObject lock36;
    public GameObject lock37;
    public GameObject lock38;
    public GameObject lock39;
    public GameObject lock40;
    public GameObject lock41;
    public GameObject lock42;
    public GameObject lock43;
    public GameObject lock44;
    public GameObject lock45;
    public GameObject lock46;
    public GameObject lock47;
    public GameObject lock48;
    public GameObject lock49;
    public GameObject lock50;
    public GameObject lock51;
    public GameObject lock52;
    public GameObject lock53;
    public GameObject lock54;
    public GameObject lock55;
    public GameObject lock56;
    public GameObject lock57;
    public GameObject lock58;
    public GameObject lock59;
    public GameObject lock60;
    public GameObject lock61;
    public GameObject lock62;
    public GameObject lock63;
    public GameObject lock64;
    public GameObject lock65;
    public GameObject lock66;
    public GameObject lock67;
    public GameObject lock68;
    public GameObject lock69;
    public GameObject lock70;
    public GameObject lock71;
    public GameObject lock72;
    public GameObject lock73;
    public GameObject lock74;
    public GameObject lock75;
    public GameObject lock76;
    public GameObject lock77;
    public GameObject lock78;
    public GameObject lock79;
    public GameObject lock80;
    public GameObject lock81;
    public GameObject lock82;
    public GameObject lock83;
    public GameObject lock84;
    public GameObject lock85;
    public GameObject lock86;
    public GameObject lock87;
    public GameObject lock88;
    public GameObject lock89;
    public GameObject lock90;
    public GameObject lock91;
    public GameObject lock92;
    public GameObject lock93;
    public GameObject lock94;
    public GameObject lock95;
    public GameObject lock96;
    public GameObject lock97;
    public GameObject lock98;
    public GameObject lock99;
    public GameObject lock100;
    public GameObject lock101;
    #endregion
    [Header("Game Stars")]
    #region Game Stars
    public GameObject star1_1;
    public GameObject star2_1;
    public GameObject star3_1;
    public GameObject star1_2;
    public GameObject star2_2;
    public GameObject star3_2;
    public GameObject star1_3;
    public GameObject star2_3;
    public GameObject star3_3;
    public GameObject star1_4;
    public GameObject star2_4;
    public GameObject star3_4;
    public GameObject star1_5;
    public GameObject star2_5;
    public GameObject star3_5;
    public GameObject star1_6;
    public GameObject star2_6;
    public GameObject star3_6;
    public GameObject star1_7;
    public GameObject star2_7;
    public GameObject star3_7;
    public GameObject star1_8;
    public GameObject star2_8;
    public GameObject star3_8;
    public GameObject star1_9;
    public GameObject star2_9;
    public GameObject star3_9;
    public GameObject star1_10;
    public GameObject star2_10;
    public GameObject star3_10;
    public GameObject star1_11;
    public GameObject star2_11;
    public GameObject star3_11;
    public GameObject star1_12;
    public GameObject star2_12;
    public GameObject star3_12;
    public GameObject star1_13;
    public GameObject star2_13;
    public GameObject star3_13;
    public GameObject star1_14;
    public GameObject star2_14;
    public GameObject star3_14;
    public GameObject star1_15;
    public GameObject star2_15;
    public GameObject star3_15;
    public GameObject star1_16;
    public GameObject star2_16;
    public GameObject star3_16;
    public GameObject star1_17;
    public GameObject star2_17;
    public GameObject star3_17;
    public GameObject star1_18;
    public GameObject star2_18;
    public GameObject star3_18;
    public GameObject star1_19;
    public GameObject star2_19;
    public GameObject star3_19;
    public GameObject star1_20;
    public GameObject star2_20;
    public GameObject star3_20;
    public GameObject star1_21;
    public GameObject star2_21;
    public GameObject star3_21;
    public GameObject star1_22;
    public GameObject star2_22;
    public GameObject star3_22;
    public GameObject star1_23;
    public GameObject star2_23;
    public GameObject star3_23;
    public GameObject star1_24;
    public GameObject star2_24;
    public GameObject star3_24;
    public GameObject star1_25;
    public GameObject star2_25;
    public GameObject star3_25;
    public GameObject star1_26;
    public GameObject star2_26;
    public GameObject star3_26;
    public GameObject star1_27;
    public GameObject star2_27;
    public GameObject star3_27;
    public GameObject star1_28;
    public GameObject star2_28;
    public GameObject star3_28;
    public GameObject star1_29;
    public GameObject star2_29;
    public GameObject star3_29;
    public GameObject star1_30;
    public GameObject star2_30;
    public GameObject star3_30;
    public GameObject star1_31;
    public GameObject star2_31;
    public GameObject star3_31;
    public GameObject star1_32;
    public GameObject star2_32;
    public GameObject star3_32;
    public GameObject star1_33;
    public GameObject star2_33;
    public GameObject star3_33;
    public GameObject star1_34;
    public GameObject star2_34;
    public GameObject star3_34;
    public GameObject star1_35;
    public GameObject star2_35;
    public GameObject star3_35;
    public GameObject star1_36;
    public GameObject star2_36;
    public GameObject star3_36;
    public GameObject star1_37;
    public GameObject star2_37;
    public GameObject star3_37;
    public GameObject star1_38;
    public GameObject star2_38;
    public GameObject star3_38;
    public GameObject star1_39;
    public GameObject star2_39;
    public GameObject star3_39;
    public GameObject star1_40;
    public GameObject star2_40;
    public GameObject star3_40;
    public GameObject star1_41;
    public GameObject star2_41;
    public GameObject star3_41;
    public GameObject star1_42;
    public GameObject star2_42;
    public GameObject star3_42;
    public GameObject star1_43;
    public GameObject star2_43;
    public GameObject star3_43;
    public GameObject star1_44;
    public GameObject star2_44;
    public GameObject star3_44;
    public GameObject star1_45;
    public GameObject star2_45;
    public GameObject star3_45;
    public GameObject star1_46;
    public GameObject star2_46;
    public GameObject star3_46;
    public GameObject star1_47;
    public GameObject star2_47;
    public GameObject star3_47;
    public GameObject star1_48;
    public GameObject star2_48;
    public GameObject star3_48;
    public GameObject star1_49;
    public GameObject star2_49;
    public GameObject star3_49;
    public GameObject star1_50;
    public GameObject star2_50;
    public GameObject star3_50;
    public GameObject star1_51;
    public GameObject star2_51;
    public GameObject star3_51;
    public GameObject star1_52;
    public GameObject star2_52;
    public GameObject star3_52;
    public GameObject star1_53;
    public GameObject star2_53;
    public GameObject star3_53;
    public GameObject star1_54;
    public GameObject star2_54;
    public GameObject star3_54;
    public GameObject star1_55;
    public GameObject star2_55;
    public GameObject star3_55;
    public GameObject star1_56;
    public GameObject star2_56;
    public GameObject star3_56;
    public GameObject star1_57;
    public GameObject star2_57;
    public GameObject star3_57;
    public GameObject star1_58;
    public GameObject star2_58;
    public GameObject star3_58;
    public GameObject star1_59;
    public GameObject star2_59;
    public GameObject star3_59;
    public GameObject star1_60;
    public GameObject star2_60;
    public GameObject star3_60;
    public GameObject star1_61;
    public GameObject star2_61;
    public GameObject star3_61;
    public GameObject star1_62;
    public GameObject star2_62;
    public GameObject star3_62;
    public GameObject star1_63;
    public GameObject star2_63;
    public GameObject star3_63;
    public GameObject star1_64;
    public GameObject star2_64;
    public GameObject star3_64;
    public GameObject star1_65;
    public GameObject star2_65;
    public GameObject star3_65;
    public GameObject star1_66;
    public GameObject star2_66;
    public GameObject star3_66;
    public GameObject star1_67;
    public GameObject star2_67;
    public GameObject star3_67;
    public GameObject star1_68;
    public GameObject star2_68;
    public GameObject star3_68;
    public GameObject star1_69;
    public GameObject star2_69;
    public GameObject star3_69;
    public GameObject star1_70;
    public GameObject star2_70;
    public GameObject star3_70;
    public GameObject star1_71;
    public GameObject star2_71;
    public GameObject star3_71;
    public GameObject star1_72;
    public GameObject star2_72;
    public GameObject star3_72;
    public GameObject star1_73;
    public GameObject star2_73;
    public GameObject star3_73;
    public GameObject star1_74;
    public GameObject star2_74;
    public GameObject star3_74;
    public GameObject star1_75;
    public GameObject star2_75;
    public GameObject star3_75;
    public GameObject star1_76;
    public GameObject star2_76;
    public GameObject star3_76;
    public GameObject star1_77;
    public GameObject star2_77;
    public GameObject star3_77;
    public GameObject star1_78;
    public GameObject star2_78;
    public GameObject star3_78;
    public GameObject star1_79;
    public GameObject star2_79;
    public GameObject star3_79;
    public GameObject star1_80;
    public GameObject star2_80;
    public GameObject star3_80;
    public GameObject star1_81;
    public GameObject star2_81;
    public GameObject star3_81;
    public GameObject star1_82;
    public GameObject star2_82;
    public GameObject star3_82;
    public GameObject star1_83;
    public GameObject star2_83;
    public GameObject star3_83;
    public GameObject star1_84;
    public GameObject star2_84;
    public GameObject star3_84;
    public GameObject star1_85;
    public GameObject star2_85;
    public GameObject star3_85;
    public GameObject star1_86;
    public GameObject star2_86;
    public GameObject star3_86;
    public GameObject star1_87;
    public GameObject star2_87;
    public GameObject star3_87;
    public GameObject star1_88;
    public GameObject star2_88;
    public GameObject star3_88;
    public GameObject star1_89;
    public GameObject star2_89;
    public GameObject star3_89;
    public GameObject star1_90;
    public GameObject star2_90;
    public GameObject star3_90;
    public GameObject star1_91;
    public GameObject star2_91;
    public GameObject star3_91;
    public GameObject star1_92;
    public GameObject star2_92;
    public GameObject star3_92;
    public GameObject star1_93;
    public GameObject star2_93;
    public GameObject star3_93;
    public GameObject star1_94;
    public GameObject star2_94;
    public GameObject star3_94;
    public GameObject star1_95;
    public GameObject star2_95;
    public GameObject star3_95;
    public GameObject star1_96;
    public GameObject star2_96;
    public GameObject star3_96;
    public GameObject star1_97;
    public GameObject star2_97;
    public GameObject star3_97;
    public GameObject star1_98;
    public GameObject star2_98;
    public GameObject star3_98;
    public GameObject star1_99;
    public GameObject star2_99;
    public GameObject star3_99;
    public GameObject star1_100;
    public GameObject star2_100;
    public GameObject star3_100;
    public GameObject star1_101;
    public GameObject star2_101;
    public GameObject star3_101;
    #endregion

    public void Awake()
    {
        AwakeMenu();
        if (PlayerPrefs.HasKey("Language"))
        { LanguageStartSelected.SetActive(false); }
        else { LanguageStartSelected.SetActive(true); }
        if (PlayerPrefs.HasKey("Start"))
        { }
        else
        {
            PlayerPrefs.SetString("Start", "true");
            PlayerPrefs.SetFloat("MusicVolume", 0.5f);
            PlayerPrefs.SetInt("AdsShow", 3);
            PlayerPrefs.SetInt("AdsShow123", 1);
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
            PlayerPrefs.SetInt("lv101", 0);
        }
        EditLock();
        TextScore();
        if (PlayerPrefs.GetInt("lv100") == 0)
        { QRCodeobj2.SetActive(false); }
        else { QRCodeobj2.SetActive(true); }
        if (PlayerPrefs.GetInt("AdsShow") > 3)
        { PlayerPrefs.SetInt("AdsShow", 3); }
        QRCodeobj.SetActive(false);
        textobj.SetActive(false);
        startobj.SetActive(false);
        optionsobj.SetActive(false);
        exitobj.SetActive(false);
        DeleteAll.SetActive(false);
        selectlanguage.SetActive(false);
        QRImage.SetActive(true);
        BonusLevel.SetActive(false);
    }

    public void Buttons(int IDBut)
    {
        switch (IDBut)
        {
            case 1:
                if (startobj.activeSelf == false)
                {
                    startobj.SetActive(true);
                    optionsobj.SetActive(false);
                    textobj.SetActive(true);
                    DeleteAll.SetActive(false);
                }
                else
                {
                    startobj.SetActive(false);
                    optionsobj.SetActive(false);
                    textobj.SetActive(false);
                    DeleteAll.SetActive(false);
                }
                break;
            case 2:
                if (optionsobj.activeSelf == false)
                {
                    optionsobj.SetActive(true);
                    startobj.SetActive(false);
                    textobj.SetActive(false);
                }
                else
                {
                    optionsobj.SetActive(false);
                    startobj.SetActive(false);
                    textobj.SetActive(false);
                }
                break;
            case 3:
                if (exitobj.activeSelf == false)
                {
                    exitobj.SetActive(true);
                    DeleteAll.SetActive(false);
                }
                else
                {
                    exitobj.SetActive(false);
                    DeleteAll.SetActive(false);
                }
                break;
            case 4:
                exitobj.SetActive(false);
                DeleteAll.SetActive(false);
                break;
            case 5:
                Application.Quit();
#if UNITY_EDITOR
                EditorApplication.isPlaying = false;
#endif
                break;
            case 6:
                DeleteAll.SetActive(true);
                exitobj.SetActive(false);
                break;
            case 7:
                selectlanguage.SetActive(true);
                break;
            case 8:
                selectlanguage.SetActive(false);
                DeleteAll.SetActive(false);
                break;
        }
    }

    public void LanguageSelected(int IDLanguage)
    {
        PlayerPrefs.SetInt("Language", IDLanguage);
        languageMenu.SetLanguage();
        LanguageStartSelected.SetActive(false);
    }

    public void ButQRCode(int x)
    {
        switch (x)
        {
            case 0:
                QRCodeobj.SetActive(true);
                break;
            case 1:
                QRCodeobj.SetActive(false);
                break;
            case 2:
                QRImage.SetActive(true);
                BonusLevel.SetActive(false);
                break;
            case 3:
                BonusLevel.SetActive(true);
                QRImage.SetActive(false);
                break;
        }
    }

    public void AwakeMenu()
    {
        star1_1.SetActive(false);
        star2_1.SetActive(false);
        star3_1.SetActive(false);
        star1_2.SetActive(false);
        star2_2.SetActive(false);
        star3_2.SetActive(false);
        star1_3.SetActive(false);
        star2_3.SetActive(false);
        star3_3.SetActive(false);
        star1_4.SetActive(false);
        star2_4.SetActive(false);
        star3_4.SetActive(false);
        star1_5.SetActive(false);
        star2_5.SetActive(false);
        star3_5.SetActive(false);
        star1_6.SetActive(false);
        star2_6.SetActive(false);
        star3_6.SetActive(false);
        star1_7.SetActive(false);
        star2_7.SetActive(false);
        star3_7.SetActive(false);
        star1_8.SetActive(false);
        star2_8.SetActive(false);
        star3_8.SetActive(false);
        star1_9.SetActive(false);
        star2_9.SetActive(false);
        star3_9.SetActive(false);
        star1_10.SetActive(false);
        star2_10.SetActive(false);
        star3_10.SetActive(false);
        star1_11.SetActive(false);
        star2_11.SetActive(false);
        star3_11.SetActive(false);
        star1_12.SetActive(false);
        star2_12.SetActive(false);
        star3_12.SetActive(false);
        star1_13.SetActive(false);
        star2_13.SetActive(false);
        star3_13.SetActive(false);
        star1_14.SetActive(false);
        star2_14.SetActive(false);
        star3_14.SetActive(false);
        star1_15.SetActive(false);
        star2_15.SetActive(false);
        star3_15.SetActive(false);
        star1_16.SetActive(false);
        star2_16.SetActive(false);
        star3_16.SetActive(false);
        star1_17.SetActive(false);
        star2_17.SetActive(false);
        star3_17.SetActive(false);
        star1_18.SetActive(false);
        star2_18.SetActive(false);
        star3_18.SetActive(false);
        star1_19.SetActive(false);
        star2_19.SetActive(false);
        star3_19.SetActive(false);
        star1_20.SetActive(false);
        star2_20.SetActive(false);
        star3_20.SetActive(false);
        star1_21.SetActive(false);
        star2_21.SetActive(false);
        star3_21.SetActive(false);
        star1_22.SetActive(false);
        star2_22.SetActive(false);
        star3_22.SetActive(false);
        star1_23.SetActive(false);
        star2_23.SetActive(false);
        star3_23.SetActive(false);
        star1_24.SetActive(false);
        star2_24.SetActive(false);
        star3_24.SetActive(false);
        star1_25.SetActive(false);
        star2_25.SetActive(false);
        star3_25.SetActive(false);
        star1_26.SetActive(false);
        star2_26.SetActive(false);
        star3_26.SetActive(false);
        star1_27.SetActive(false);
        star2_27.SetActive(false);
        star3_27.SetActive(false);
        star1_28.SetActive(false);
        star2_28.SetActive(false);
        star3_28.SetActive(false);
        star1_29.SetActive(false);
        star2_29.SetActive(false);
        star3_29.SetActive(false);
        star1_30.SetActive(false);
        star2_30.SetActive(false);
        star3_30.SetActive(false);
        star1_31.SetActive(false);
        star2_31.SetActive(false);
        star3_31.SetActive(false);
        star1_32.SetActive(false);
        star2_32.SetActive(false);
        star3_32.SetActive(false);
        star1_33.SetActive(false);
        star2_33.SetActive(false);
        star3_33.SetActive(false);
        star1_34.SetActive(false);
        star2_34.SetActive(false);
        star3_34.SetActive(false);
        star1_35.SetActive(false);
        star2_35.SetActive(false);
        star3_35.SetActive(false);
        star1_36.SetActive(false);
        star2_36.SetActive(false);
        star3_36.SetActive(false);
        star1_37.SetActive(false);
        star2_37.SetActive(false);
        star3_37.SetActive(false);
        star1_38.SetActive(false);
        star2_38.SetActive(false);
        star3_38.SetActive(false);
        star1_39.SetActive(false);
        star2_39.SetActive(false);
        star3_39.SetActive(false);
        star1_40.SetActive(false);
        star2_40.SetActive(false);
        star3_40.SetActive(false);
        star1_41.SetActive(false);
        star2_41.SetActive(false);
        star3_41.SetActive(false);
        star1_42.SetActive(false);
        star2_42.SetActive(false);
        star3_42.SetActive(false);
        star1_43.SetActive(false);
        star2_43.SetActive(false);
        star3_43.SetActive(false);
        star1_44.SetActive(false);
        star2_44.SetActive(false);
        star3_44.SetActive(false);
        star1_45.SetActive(false);
        star2_45.SetActive(false);
        star3_45.SetActive(false);
        star1_46.SetActive(false);
        star2_46.SetActive(false);
        star3_46.SetActive(false);
        star1_47.SetActive(false);
        star2_47.SetActive(false);
        star3_47.SetActive(false);
        star1_48.SetActive(false);
        star2_48.SetActive(false);
        star3_48.SetActive(false);
        star1_49.SetActive(false);
        star2_49.SetActive(false);
        star3_49.SetActive(false);
        star1_50.SetActive(false);
        star2_50.SetActive(false);
        star3_50.SetActive(false);
        star1_51.SetActive(false);
        star2_51.SetActive(false);
        star3_51.SetActive(false);
        star1_52.SetActive(false);
        star2_52.SetActive(false);
        star3_52.SetActive(false);
        star1_53.SetActive(false);
        star2_53.SetActive(false);
        star3_53.SetActive(false);
        star1_54.SetActive(false);
        star2_54.SetActive(false);
        star3_54.SetActive(false);
        star1_55.SetActive(false);
        star2_55.SetActive(false);
        star3_55.SetActive(false);
        star1_56.SetActive(false);
        star2_56.SetActive(false);
        star3_56.SetActive(false);
        star1_57.SetActive(false);
        star2_57.SetActive(false);
        star3_57.SetActive(false);
        star1_58.SetActive(false);
        star2_58.SetActive(false);
        star3_58.SetActive(false);
        star1_59.SetActive(false);
        star2_59.SetActive(false);
        star3_59.SetActive(false);
        star1_60.SetActive(false);
        star2_60.SetActive(false);
        star3_60.SetActive(false);
        star1_61.SetActive(false);
        star2_61.SetActive(false);
        star3_61.SetActive(false);
        star1_62.SetActive(false);
        star2_62.SetActive(false);
        star3_62.SetActive(false);
        star1_63.SetActive(false);
        star2_63.SetActive(false);
        star3_63.SetActive(false);
        star1_64.SetActive(false);
        star2_64.SetActive(false);
        star3_64.SetActive(false);
        star1_65.SetActive(false);
        star2_65.SetActive(false);
        star3_65.SetActive(false);
        star1_66.SetActive(false);
        star2_66.SetActive(false);
        star3_66.SetActive(false);
        star1_67.SetActive(false);
        star2_67.SetActive(false);
        star3_67.SetActive(false);
        star1_68.SetActive(false);
        star2_68.SetActive(false);
        star3_68.SetActive(false);
        star1_69.SetActive(false);
        star2_69.SetActive(false);
        star3_69.SetActive(false);
        star1_70.SetActive(false);
        star2_70.SetActive(false);
        star3_70.SetActive(false);
        star1_71.SetActive(false);
        star2_71.SetActive(false);
        star3_71.SetActive(false);
        star1_72.SetActive(false);
        star2_72.SetActive(false);
        star3_72.SetActive(false);
        star1_73.SetActive(false);
        star2_73.SetActive(false);
        star3_73.SetActive(false);
        star1_74.SetActive(false);
        star2_74.SetActive(false);
        star3_74.SetActive(false);
        star1_75.SetActive(false);
        star2_75.SetActive(false);
        star3_75.SetActive(false);
        star1_76.SetActive(false);
        star2_76.SetActive(false);
        star3_76.SetActive(false);
        star1_77.SetActive(false);
        star2_77.SetActive(false);
        star3_77.SetActive(false);
        star1_78.SetActive(false);
        star2_78.SetActive(false);
        star3_78.SetActive(false);
        star1_79.SetActive(false);
        star2_79.SetActive(false);
        star3_79.SetActive(false);
        star1_80.SetActive(false);
        star2_80.SetActive(false);
        star3_80.SetActive(false);
        star1_81.SetActive(false);
        star2_81.SetActive(false);
        star3_81.SetActive(false);
        star1_82.SetActive(false);
        star2_82.SetActive(false);
        star3_82.SetActive(false);
        star1_83.SetActive(false);
        star2_83.SetActive(false);
        star3_83.SetActive(false);
        star1_84.SetActive(false);
        star2_84.SetActive(false);
        star3_84.SetActive(false);
        star1_85.SetActive(false);
        star2_85.SetActive(false);
        star3_85.SetActive(false);
        star1_86.SetActive(false);
        star2_86.SetActive(false);
        star3_86.SetActive(false);
        star1_87.SetActive(false);
        star2_87.SetActive(false);
        star3_87.SetActive(false);
        star1_88.SetActive(false);
        star2_88.SetActive(false);
        star3_88.SetActive(false);
        star1_89.SetActive(false);
        star2_89.SetActive(false);
        star3_89.SetActive(false);
        star1_90.SetActive(false);
        star2_90.SetActive(false);
        star3_90.SetActive(false);
        star1_91.SetActive(false);
        star2_91.SetActive(false);
        star3_91.SetActive(false);
        star1_92.SetActive(false);
        star2_92.SetActive(false);
        star3_92.SetActive(false);
        star1_93.SetActive(false);
        star2_93.SetActive(false);
        star3_93.SetActive(false);
        star1_94.SetActive(false);
        star2_94.SetActive(false);
        star3_94.SetActive(false);
        star1_95.SetActive(false);
        star2_95.SetActive(false);
        star3_95.SetActive(false);
        star1_96.SetActive(false);
        star2_96.SetActive(false);
        star3_96.SetActive(false);
        star1_97.SetActive(false);
        star2_97.SetActive(false);
        star3_97.SetActive(false);
        star1_98.SetActive(false);
        star2_98.SetActive(false);
        star3_98.SetActive(false);
        star1_99.SetActive(false);
        star2_99.SetActive(false);
        star3_99.SetActive(false);
        star1_100.SetActive(false);
        star2_100.SetActive(false);
        star3_100.SetActive(false);
        star1_101.SetActive(false);
        star2_101.SetActive(false);
        star3_101.SetActive(false);
    }

    public void SceneGo(int ID)
    {
        if (PlayerPrefs.GetInt("lv" + ID.ToString()) == 0)
        {
            Debug.Log("Lock" + ID.ToString());
        }
        else
        {
            SceneManager.LoadScene(ID + 1);
        }
    }

    public void EditLock()
    {
        if (PlayerPrefs.GetInt("lv2") == 0) { lock2.SetActive(true); } else { lock2.SetActive(false); }
        if (PlayerPrefs.GetInt("lv3") == 0) { lock3.SetActive(true); } else { lock3.SetActive(false); }
        if (PlayerPrefs.GetInt("lv4") == 0) { lock4.SetActive(true); } else { lock4.SetActive(false); }
        if (PlayerPrefs.GetInt("lv5") == 0) { lock5.SetActive(true); } else { lock5.SetActive(false); }
        if (PlayerPrefs.GetInt("lv6") == 0) { lock6.SetActive(true); } else { lock6.SetActive(false); }
        if (PlayerPrefs.GetInt("lv7") == 0) { lock7.SetActive(true); } else { lock7.SetActive(false); }
        if (PlayerPrefs.GetInt("lv8") == 0) { lock8.SetActive(true); } else { lock8.SetActive(false); }
        if (PlayerPrefs.GetInt("lv9") == 0) { lock9.SetActive(true); } else { lock9.SetActive(false); }
        if (PlayerPrefs.GetInt("lv10") == 0) { lock10.SetActive(true); } else { lock10.SetActive(false); }
        if (PlayerPrefs.GetInt("lv11") == 0) { lock11.SetActive(true); } else { lock11.SetActive(false); }
        if (PlayerPrefs.GetInt("lv12") == 0) { lock12.SetActive(true); } else { lock12.SetActive(false); }
        if (PlayerPrefs.GetInt("lv13") == 0) { lock13.SetActive(true); } else { lock13.SetActive(false); }
        if (PlayerPrefs.GetInt("lv14") == 0) { lock14.SetActive(true); } else { lock14.SetActive(false); }
        if (PlayerPrefs.GetInt("lv15") == 0) { lock15.SetActive(true); } else { lock15.SetActive(false); }
        if (PlayerPrefs.GetInt("lv16") == 0) { lock16.SetActive(true); } else { lock16.SetActive(false); }
        if (PlayerPrefs.GetInt("lv17") == 0) { lock17.SetActive(true); } else { lock17.SetActive(false); }
        if (PlayerPrefs.GetInt("lv18") == 0) { lock18.SetActive(true); } else { lock18.SetActive(false); }
        if (PlayerPrefs.GetInt("lv19") == 0) { lock19.SetActive(true); } else { lock19.SetActive(false); }
        if (PlayerPrefs.GetInt("lv20") == 0) { lock20.SetActive(true); } else { lock20.SetActive(false); }
        if (PlayerPrefs.GetInt("lv21") == 0) { lock21.SetActive(true); } else { lock21.SetActive(false); }
        if (PlayerPrefs.GetInt("lv22") == 0) { lock22.SetActive(true); } else { lock22.SetActive(false); }
        if (PlayerPrefs.GetInt("lv23") == 0) { lock23.SetActive(true); } else { lock23.SetActive(false); }
        if (PlayerPrefs.GetInt("lv24") == 0) { lock24.SetActive(true); } else { lock24.SetActive(false); }
        if (PlayerPrefs.GetInt("lv25") == 0) { lock25.SetActive(true); } else { lock25.SetActive(false); }
        if (PlayerPrefs.GetInt("lv26") == 0) { lock26.SetActive(true); } else { lock26.SetActive(false); }
        if (PlayerPrefs.GetInt("lv27") == 0) { lock27.SetActive(true); } else { lock27.SetActive(false); }
        if (PlayerPrefs.GetInt("lv28") == 0) { lock28.SetActive(true); } else { lock28.SetActive(false); }
        if (PlayerPrefs.GetInt("lv29") == 0) { lock29.SetActive(true); } else { lock29.SetActive(false); }
        if (PlayerPrefs.GetInt("lv30") == 0) { lock30.SetActive(true); } else { lock30.SetActive(false); }
        if (PlayerPrefs.GetInt("lv31") == 0) { lock31.SetActive(true); } else { lock31.SetActive(false); }
        if (PlayerPrefs.GetInt("lv32") == 0) { lock32.SetActive(true); } else { lock32.SetActive(false); }
        if (PlayerPrefs.GetInt("lv33") == 0) { lock33.SetActive(true); } else { lock33.SetActive(false); }
        if (PlayerPrefs.GetInt("lv34") == 0) { lock34.SetActive(true); } else { lock34.SetActive(false); }
        if (PlayerPrefs.GetInt("lv35") == 0) { lock35.SetActive(true); } else { lock35.SetActive(false); }
        if (PlayerPrefs.GetInt("lv36") == 0) { lock36.SetActive(true); } else { lock36.SetActive(false); }
        if (PlayerPrefs.GetInt("lv37") == 0) { lock37.SetActive(true); } else { lock37.SetActive(false); }
        if (PlayerPrefs.GetInt("lv38") == 0) { lock38.SetActive(true); } else { lock38.SetActive(false); }
        if (PlayerPrefs.GetInt("lv39") == 0) { lock39.SetActive(true); } else { lock39.SetActive(false); }
        if (PlayerPrefs.GetInt("lv40") == 0) { lock40.SetActive(true); } else { lock40.SetActive(false); }
        if (PlayerPrefs.GetInt("lv41") == 0) { lock41.SetActive(true); } else { lock41.SetActive(false); }
        if (PlayerPrefs.GetInt("lv42") == 0) { lock42.SetActive(true); } else { lock42.SetActive(false); }
        if (PlayerPrefs.GetInt("lv43") == 0) { lock43.SetActive(true); } else { lock43.SetActive(false); }
        if (PlayerPrefs.GetInt("lv44") == 0) { lock44.SetActive(true); } else { lock44.SetActive(false); }
        if (PlayerPrefs.GetInt("lv45") == 0) { lock45.SetActive(true); } else { lock45.SetActive(false); }
        if (PlayerPrefs.GetInt("lv46") == 0) { lock46.SetActive(true); } else { lock46.SetActive(false); }
        if (PlayerPrefs.GetInt("lv47") == 0) { lock47.SetActive(true); } else { lock47.SetActive(false); }
        if (PlayerPrefs.GetInt("lv48") == 0) { lock48.SetActive(true); } else { lock48.SetActive(false); }
        if (PlayerPrefs.GetInt("lv49") == 0) { lock49.SetActive(true); } else { lock49.SetActive(false); }
        if (PlayerPrefs.GetInt("lv50") == 0) { lock50.SetActive(true); } else { lock50.SetActive(false); }
        if (PlayerPrefs.GetInt("lv51") == 0) { lock51.SetActive(true); } else { lock51.SetActive(false); }
        if (PlayerPrefs.GetInt("lv52") == 0) { lock52.SetActive(true); } else { lock52.SetActive(false); }
        if (PlayerPrefs.GetInt("lv53") == 0) { lock53.SetActive(true); } else { lock53.SetActive(false); }
        if (PlayerPrefs.GetInt("lv54") == 0) { lock54.SetActive(true); } else { lock54.SetActive(false); }
        if (PlayerPrefs.GetInt("lv55") == 0) { lock55.SetActive(true); } else { lock55.SetActive(false); }
        if (PlayerPrefs.GetInt("lv56") == 0) { lock56.SetActive(true); } else { lock56.SetActive(false); }
        if (PlayerPrefs.GetInt("lv57") == 0) { lock57.SetActive(true); } else { lock57.SetActive(false); }
        if (PlayerPrefs.GetInt("lv58") == 0) { lock58.SetActive(true); } else { lock58.SetActive(false); }
        if (PlayerPrefs.GetInt("lv59") == 0) { lock59.SetActive(true); } else { lock59.SetActive(false); }
        if (PlayerPrefs.GetInt("lv60") == 0) { lock60.SetActive(true); } else { lock60.SetActive(false); }
        if (PlayerPrefs.GetInt("lv61") == 0) { lock61.SetActive(true); } else { lock61.SetActive(false); }
        if (PlayerPrefs.GetInt("lv62") == 0) { lock62.SetActive(true); } else { lock62.SetActive(false); }
        if (PlayerPrefs.GetInt("lv63") == 0) { lock63.SetActive(true); } else { lock63.SetActive(false); }
        if (PlayerPrefs.GetInt("lv64") == 0) { lock64.SetActive(true); } else { lock64.SetActive(false); }
        if (PlayerPrefs.GetInt("lv65") == 0) { lock65.SetActive(true); } else { lock65.SetActive(false); }
        if (PlayerPrefs.GetInt("lv66") == 0) { lock66.SetActive(true); } else { lock66.SetActive(false); }
        if (PlayerPrefs.GetInt("lv67") == 0) { lock67.SetActive(true); } else { lock67.SetActive(false); }
        if (PlayerPrefs.GetInt("lv68") == 0) { lock68.SetActive(true); } else { lock68.SetActive(false); }
        if (PlayerPrefs.GetInt("lv69") == 0) { lock69.SetActive(true); } else { lock69.SetActive(false); }
        if (PlayerPrefs.GetInt("lv70") == 0) { lock70.SetActive(true); } else { lock70.SetActive(false); }
        if (PlayerPrefs.GetInt("lv71") == 0) { lock71.SetActive(true); } else { lock71.SetActive(false); }
        if (PlayerPrefs.GetInt("lv72") == 0) { lock72.SetActive(true); } else { lock72.SetActive(false); }
        if (PlayerPrefs.GetInt("lv73") == 0) { lock73.SetActive(true); } else { lock73.SetActive(false); }
        if (PlayerPrefs.GetInt("lv74") == 0) { lock74.SetActive(true); } else { lock74.SetActive(false); }
        if (PlayerPrefs.GetInt("lv75") == 0) { lock75.SetActive(true); } else { lock75.SetActive(false); }
        if (PlayerPrefs.GetInt("lv76") == 0) { lock76.SetActive(true); } else { lock76.SetActive(false); }
        if (PlayerPrefs.GetInt("lv77") == 0) { lock77.SetActive(true); } else { lock77.SetActive(false); }
        if (PlayerPrefs.GetInt("lv78") == 0) { lock78.SetActive(true); } else { lock78.SetActive(false); }
        if (PlayerPrefs.GetInt("lv79") == 0) { lock79.SetActive(true); } else { lock79.SetActive(false); }
        if (PlayerPrefs.GetInt("lv80") == 0) { lock80.SetActive(true); } else { lock80.SetActive(false); }
        if (PlayerPrefs.GetInt("lv81") == 0) { lock81.SetActive(true); } else { lock81.SetActive(false); }
        if (PlayerPrefs.GetInt("lv82") == 0) { lock82.SetActive(true); } else { lock82.SetActive(false); }
        if (PlayerPrefs.GetInt("lv83") == 0) { lock83.SetActive(true); } else { lock83.SetActive(false); }
        if (PlayerPrefs.GetInt("lv84") == 0) { lock84.SetActive(true); } else { lock84.SetActive(false); }
        if (PlayerPrefs.GetInt("lv85") == 0) { lock85.SetActive(true); } else { lock85.SetActive(false); }
        if (PlayerPrefs.GetInt("lv86") == 0) { lock86.SetActive(true); } else { lock86.SetActive(false); }
        if (PlayerPrefs.GetInt("lv87") == 0) { lock87.SetActive(true); } else { lock87.SetActive(false); }
        if (PlayerPrefs.GetInt("lv88") == 0) { lock88.SetActive(true); } else { lock88.SetActive(false); }
        if (PlayerPrefs.GetInt("lv89") == 0) { lock89.SetActive(true); } else { lock89.SetActive(false); }
        if (PlayerPrefs.GetInt("lv90") == 0) { lock90.SetActive(true); } else { lock90.SetActive(false); }
        if (PlayerPrefs.GetInt("lv91") == 0) { lock91.SetActive(true); } else { lock91.SetActive(false); }
        if (PlayerPrefs.GetInt("lv92") == 0) { lock92.SetActive(true); } else { lock92.SetActive(false); }
        if (PlayerPrefs.GetInt("lv93") == 0) { lock93.SetActive(true); } else { lock93.SetActive(false); }
        if (PlayerPrefs.GetInt("lv94") == 0) { lock94.SetActive(true); } else { lock94.SetActive(false); }
        if (PlayerPrefs.GetInt("lv95") == 0) { lock95.SetActive(true); } else { lock95.SetActive(false); }
        if (PlayerPrefs.GetInt("lv96") == 0) { lock96.SetActive(true); } else { lock96.SetActive(false); }
        if (PlayerPrefs.GetInt("lv97") == 0) { lock97.SetActive(true); } else { lock97.SetActive(false); }
        if (PlayerPrefs.GetInt("lv98") == 0) { lock98.SetActive(true); } else { lock98.SetActive(false); }
        if (PlayerPrefs.GetInt("lv99") == 0) { lock99.SetActive(true); } else { lock99.SetActive(false); }
        if (PlayerPrefs.GetInt("lv100") == 0) { lock100.SetActive(true); } else { lock100.SetActive(false); }
        if (PlayerPrefs.GetInt("lv101") == 0) { lock101.SetActive(true); } else { lock101.SetActive(false); }
    }

    public void TextScore()
    {
        int x = 0;
        switch (PlayerPrefs.GetInt("lv1"))
        {
            case 2:
                star1_1.SetActive(true); x = x + 1; break;
            case 3:
                star1_1.SetActive(true);
                star2_1.SetActive(true); x = x + 2; break;
            case 4:
                star1_1.SetActive(true);
                star3_1.SetActive(true); x = x + 2; break;
            case 5:
                star1_1.SetActive(true);
                star2_1.SetActive(true);
                star3_1.SetActive(true); x = x + 3; break;
        }
        switch (PlayerPrefs.GetInt("lv2"))
        {
            case 2:
                star1_2.SetActive(true); x = x + 1; break;
            case 3:
                star1_2.SetActive(true);
                star2_2.SetActive(true); x = x + 2; break;
            case 4:
                star1_2.SetActive(true);
                star3_2.SetActive(true); x = x + 2; break;
            case 5:
                star1_2.SetActive(true);
                star2_2.SetActive(true);
                star3_2.SetActive(true); x = x + 3; break;
        }
        switch (PlayerPrefs.GetInt("lv3"))
        {
            case 2:
                star1_3.SetActive(true); x = x + 1; break;
            case 3:
                star1_3.SetActive(true);
                star2_3.SetActive(true); x = x + 2; break;
            case 4:
                star1_3.SetActive(true);
                star3_3.SetActive(true); x = x + 2; break;
            case 5:
                star1_3.SetActive(true);
                star2_3.SetActive(true);
                star3_3.SetActive(true); x = x + 3; break;
        }
        switch (PlayerPrefs.GetInt("lv4"))
        {
            case 2:
                star1_4.SetActive(true); x = x + 1; break;
            case 3:
                star1_4.SetActive(true);
                star2_4.SetActive(true); x = x + 2; break;
            case 4:
                star1_4.SetActive(true);
                star3_4.SetActive(true); x = x + 2; break;
            case 5:
                star1_4.SetActive(true);
                star2_4.SetActive(true);
                star3_4.SetActive(true); x = x + 3; break;
        }
        switch (PlayerPrefs.GetInt("lv5"))
        {
            case 2:
                star1_5.SetActive(true); x = x + 1; break;
            case 3:
                star1_5.SetActive(true);
                star2_5.SetActive(true); x = x + 2; break;
            case 4:
                star1_5.SetActive(true);
                star3_5.SetActive(true); x = x + 2; break;
            case 5:
                star1_5.SetActive(true);
                star2_5.SetActive(true);
                star3_5.SetActive(true); x = x + 3; break;
        }
        switch (PlayerPrefs.GetInt("lv6"))
        {
            case 2:
                star1_6.SetActive(true); x = x + 1; break;
            case 3:
                star1_6.SetActive(true);
                star2_6.SetActive(true); x = x + 2; break;
            case 4:
                star1_6.SetActive(true);
                star3_6.SetActive(true); x = x + 2; break;
            case 5:
                star1_6.SetActive(true);
                star2_6.SetActive(true);
                star3_6.SetActive(true); x = x + 3; break;
        }
        switch (PlayerPrefs.GetInt("lv7"))
        {
            case 2:
                star1_7.SetActive(true); x = x + 1; break;
            case 3:
                star1_7.SetActive(true);
                star2_7.SetActive(true); x = x + 2; break;
            case 4:
                star1_7.SetActive(true);
                star3_7.SetActive(true); x = x + 2; break;
            case 5:
                star1_7.SetActive(true);
                star2_7.SetActive(true);
                star3_7.SetActive(true); x = x + 3; break;
        }
        switch (PlayerPrefs.GetInt("lv8"))
        {
            case 2:
                star1_8.SetActive(true); x = x + 1; break;
            case 3:
                star1_8.SetActive(true);
                star2_8.SetActive(true); x = x + 2; break;
            case 4:
                star1_8.SetActive(true);
                star3_8.SetActive(true); x = x + 2; break;
            case 5:
                star1_8.SetActive(true);
                star2_8.SetActive(true);
                star3_8.SetActive(true); x = x + 3; break;
        }
        switch (PlayerPrefs.GetInt("lv9"))
        {
            case 2:
                star1_9.SetActive(true); x = x + 1; break;
            case 3:
                star1_9.SetActive(true);
                star2_9.SetActive(true); x = x + 2; break;
            case 4:
                star1_9.SetActive(true);
                star3_9.SetActive(true); x = x + 2; break;
            case 5:
                star1_9.SetActive(true);
                star2_9.SetActive(true);
                star3_9.SetActive(true); x = x + 3; break;
        }
        switch (PlayerPrefs.GetInt("lv10"))
        {
            case 2:
                star1_10.SetActive(true); x = x + 1; break;
            case 3:
                star1_10.SetActive(true);
                star2_10.SetActive(true); x = x + 2; break;
            case 4:
                star1_10.SetActive(true);
                star3_10.SetActive(true); x = x + 2; break;
            case 5:
                star1_10.SetActive(true);
                star2_10.SetActive(true);
                star3_10.SetActive(true); x = x + 3; break;
        }
        switch (PlayerPrefs.GetInt("lv11"))
        {
            case 2:
                star1_11.SetActive(true); x = x + 1; break;
            case 3:
                star1_11.SetActive(true);
                star2_11.SetActive(true); x = x + 2; break;
            case 4:
                star1_11.SetActive(true);
                star3_11.SetActive(true); x = x + 2; break;
            case 5:
                star1_11.SetActive(true);
                star2_11.SetActive(true);
                star3_11.SetActive(true); x = x + 3; break;
        }
        switch (PlayerPrefs.GetInt("lv12"))
        {
            case 2:
                star1_12.SetActive(true); x = x + 1; break;
            case 3:
                star1_12.SetActive(true);
                star2_12.SetActive(true); x = x + 2; break;
            case 4:
                star1_12.SetActive(true);
                star3_12.SetActive(true); x = x + 2; break;
            case 5:
                star1_12.SetActive(true);
                star2_12.SetActive(true);
                star3_12.SetActive(true); x = x + 3; break;
        }
        switch (PlayerPrefs.GetInt("lv13"))
        {
            case 2:
                star1_13.SetActive(true); x = x + 1; break;
            case 3:
                star1_13.SetActive(true);
                star2_13.SetActive(true); x = x + 2; break;
            case 4:
                star1_13.SetActive(true);
                star3_13.SetActive(true); x = x + 2; break;
            case 5:
                star1_13.SetActive(true);
                star2_13.SetActive(true);
                star3_13.SetActive(true); x = x + 3; break;
        }
        switch (PlayerPrefs.GetInt("lv14"))
        {
            case 2:
                star1_14.SetActive(true); x = x + 1; break;
            case 3:
                star1_14.SetActive(true);
                star2_14.SetActive(true); x = x + 2; break;
            case 4:
                star1_14.SetActive(true);
                star3_14.SetActive(true); x = x + 2; break;
            case 5:
                star1_14.SetActive(true);
                star2_14.SetActive(true);
                star3_14.SetActive(true); x = x + 3; break;
        }
        switch (PlayerPrefs.GetInt("lv15"))
        {
            case 2:
                star1_15.SetActive(true); x = x + 1; break;
            case 3:
                star1_15.SetActive(true);
                star2_15.SetActive(true); x = x + 2; break;
            case 4:
                star1_15.SetActive(true);
                star3_15.SetActive(true); x = x + 2; break;
            case 5:
                star1_15.SetActive(true);
                star2_15.SetActive(true);
                star3_15.SetActive(true); x = x + 3; break;
        }
        switch (PlayerPrefs.GetInt("lv16"))
        {
            case 2:
                star1_16.SetActive(true); x = x + 1; break;
            case 3:
                star1_16.SetActive(true);
                star2_16.SetActive(true); x = x + 2; break;
            case 4:
                star1_16.SetActive(true);
                star3_16.SetActive(true); x = x + 2; break;
            case 5:
                star1_16.SetActive(true);
                star2_16.SetActive(true);
                star3_16.SetActive(true); x = x + 3; break;
        }
        switch (PlayerPrefs.GetInt("lv17"))
        {
            case 2:
                star1_17.SetActive(true); x = x + 1; break;
            case 3:
                star1_17.SetActive(true);
                star2_17.SetActive(true); x = x + 2; break;
            case 4:
                star1_17.SetActive(true);
                star3_17.SetActive(true); x = x + 2; break;
            case 5:
                star1_17.SetActive(true);
                star2_17.SetActive(true);
                star3_17.SetActive(true); x = x + 3; break;
        }
        switch (PlayerPrefs.GetInt("lv18"))
        {
            case 2:
                star1_18.SetActive(true); x = x + 1; break;
            case 3:
                star1_18.SetActive(true);
                star2_18.SetActive(true); x = x + 2; break;
            case 4:
                star1_18.SetActive(true);
                star3_18.SetActive(true); x = x + 2; break;
            case 5:
                star1_18.SetActive(true);
                star2_18.SetActive(true);
                star3_18.SetActive(true); x = x + 3; break;
        }
        switch (PlayerPrefs.GetInt("lv19"))
        {
            case 2:
                star1_19.SetActive(true); x = x + 1; break;
            case 3:
                star1_19.SetActive(true);
                star2_19.SetActive(true); x = x + 2; break;
            case 4:
                star1_19.SetActive(true);
                star3_19.SetActive(true); x = x + 2; break;
            case 5:
                star1_19.SetActive(true);
                star2_19.SetActive(true);
                star3_19.SetActive(true); x = x + 3; break;
        }
        switch (PlayerPrefs.GetInt("lv20"))
        {
            case 2:
                star1_20.SetActive(true); x = x + 1; break;
            case 3:
                star1_20.SetActive(true);
                star2_20.SetActive(true); x = x + 2; break;
            case 4:
                star1_20.SetActive(true);
                star3_20.SetActive(true); x = x + 2; break;
            case 5:
                star1_20.SetActive(true);
                star2_20.SetActive(true);
                star3_20.SetActive(true); x = x + 3; break;
        }
        switch (PlayerPrefs.GetInt("lv21"))
        {
            case 2:
                star1_21.SetActive(true); x = x + 1; break;
            case 3:
                star1_21.SetActive(true);
                star2_21.SetActive(true); x = x + 2; break;
            case 4:
                star1_21.SetActive(true);
                star3_21.SetActive(true); x = x + 2; break;
            case 5:
                star1_21.SetActive(true);
                star2_21.SetActive(true);
                star3_21.SetActive(true); x = x + 3; break;
        }
        switch (PlayerPrefs.GetInt("lv22"))
        {
            case 2:
                star1_22.SetActive(true); x = x + 1; break;
            case 3:
                star1_22.SetActive(true);
                star2_22.SetActive(true); x = x + 2; break;
            case 4:
                star1_22.SetActive(true);
                star3_22.SetActive(true); x = x + 2; break;
            case 5:
                star1_22.SetActive(true);
                star2_22.SetActive(true);
                star3_22.SetActive(true); x = x + 3; break;
        }
        switch (PlayerPrefs.GetInt("lv23"))
        {
            case 2:
                star1_23.SetActive(true); x = x + 1; break;
            case 3:
                star1_23.SetActive(true);
                star2_23.SetActive(true); x = x + 2; break;
            case 4:
                star1_23.SetActive(true);
                star3_23.SetActive(true); x = x + 2; break;
            case 5:
                star1_23.SetActive(true);
                star2_23.SetActive(true);
                star3_23.SetActive(true); x = x + 3; break;
        }
        switch (PlayerPrefs.GetInt("lv24"))
        {
            case 2:
                star1_24.SetActive(true); x = x + 1; break;
            case 3:
                star1_24.SetActive(true);
                star2_24.SetActive(true); x = x + 2; break;
            case 4:
                star1_24.SetActive(true);
                star3_24.SetActive(true); x = x + 2; break;
            case 5:
                star1_24.SetActive(true);
                star2_24.SetActive(true);
                star3_24.SetActive(true); x = x + 3; break;
        }
        switch (PlayerPrefs.GetInt("lv25"))
        {
            case 2:
                star1_25.SetActive(true); x = x + 1; break;
            case 3:
                star1_25.SetActive(true);
                star2_25.SetActive(true); x = x + 2; break;
            case 4:
                star1_25.SetActive(true);
                star3_25.SetActive(true); x = x + 2; break;
            case 5:
                star1_25.SetActive(true);
                star2_25.SetActive(true);
                star3_25.SetActive(true); x = x + 3; break;
        }
        switch (PlayerPrefs.GetInt("lv26"))
        {
            case 2:
                star1_26.SetActive(true); x = x + 1; break;
            case 3:
                star1_26.SetActive(true);
                star2_26.SetActive(true); x = x + 2; break;
            case 4:
                star1_26.SetActive(true);
                star3_26.SetActive(true); x = x + 2; break;
            case 5:
                star1_26.SetActive(true);
                star2_26.SetActive(true);
                star3_26.SetActive(true); x = x + 3; break;
        }
        switch (PlayerPrefs.GetInt("lv27"))
        {
            case 2:
                star1_27.SetActive(true); x = x + 1; break;
            case 3:
                star1_27.SetActive(true);
                star2_27.SetActive(true); x = x + 2; break;
            case 4:
                star1_27.SetActive(true);
                star3_27.SetActive(true); x = x + 2; break;
            case 5:
                star1_27.SetActive(true);
                star2_27.SetActive(true);
                star3_27.SetActive(true); x = x + 3; break;
        }
        switch (PlayerPrefs.GetInt("lv28"))
        {
            case 2:
                star1_28.SetActive(true); x = x + 1; break;
            case 3:
                star1_28.SetActive(true);
                star2_28.SetActive(true); x = x + 2; break;
            case 4:
                star1_28.SetActive(true);
                star3_28.SetActive(true); x = x + 2; break;
            case 5:
                star1_28.SetActive(true);
                star2_28.SetActive(true);
                star3_28.SetActive(true); x = x + 3; break;
        }
        switch (PlayerPrefs.GetInt("lv29"))
        {
            case 2:
                star1_29.SetActive(true); x = x + 1; break;
            case 3:
                star1_29.SetActive(true);
                star2_29.SetActive(true); x = x + 2; break;
            case 4:
                star1_29.SetActive(true);
                star3_29.SetActive(true); x = x + 2; break;
            case 5:
                star1_29.SetActive(true);
                star2_29.SetActive(true);
                star3_29.SetActive(true); x = x + 3; break;
        }
        switch (PlayerPrefs.GetInt("lv30"))
        {
            case 2:
                star1_30.SetActive(true); x = x + 1; break;
            case 3:
                star1_30.SetActive(true);
                star2_30.SetActive(true); x = x + 2; break;
            case 4:
                star1_30.SetActive(true);
                star3_30.SetActive(true); x = x + 2; break;
            case 5:
                star1_30.SetActive(true);
                star2_30.SetActive(true);
                star3_30.SetActive(true); x = x + 3; break;
        }
        switch (PlayerPrefs.GetInt("lv31"))
        {
            case 2:
                star1_31.SetActive(true); x = x + 1; break;
            case 3:
                star1_31.SetActive(true);
                star2_31.SetActive(true); x = x + 2; break;
            case 4:
                star1_31.SetActive(true);
                star3_31.SetActive(true); x = x + 2; break;
            case 5:
                star1_31.SetActive(true);
                star2_31.SetActive(true);
                star3_31.SetActive(true); x = x + 3; break;
        }
        switch (PlayerPrefs.GetInt("lv32"))
        {
            case 2:
                star1_32.SetActive(true); x = x + 1; break;
            case 3:
                star1_32.SetActive(true);
                star2_32.SetActive(true); x = x + 2; break;
            case 4:
                star1_32.SetActive(true);
                star3_32.SetActive(true); x = x + 2; break;
            case 5:
                star1_32.SetActive(true);
                star2_32.SetActive(true);
                star3_32.SetActive(true); x = x + 3; break;
        }
        switch (PlayerPrefs.GetInt("lv33"))
        {
            case 2:
                star1_33.SetActive(true); x = x + 1; break;
            case 3:
                star1_33.SetActive(true);
                star2_33.SetActive(true); x = x + 2; break;
            case 4:
                star1_33.SetActive(true);
                star3_33.SetActive(true); x = x + 2; break;
            case 5:
                star1_33.SetActive(true);
                star2_33.SetActive(true);
                star3_33.SetActive(true); x = x + 3; break;
        }
        switch (PlayerPrefs.GetInt("lv34"))
        {
            case 2:
                star1_34.SetActive(true); x = x + 1; break;
            case 3:
                star1_34.SetActive(true);
                star2_34.SetActive(true); x = x + 2; break;
            case 4:
                star1_34.SetActive(true);
                star3_34.SetActive(true); x = x + 2; break;
            case 5:
                star1_34.SetActive(true);
                star2_34.SetActive(true);
                star3_34.SetActive(true); x = x + 3; break;
        }
        switch (PlayerPrefs.GetInt("lv35"))
        {
            case 2:
                star1_35.SetActive(true); x = x + 1; break;
            case 3:
                star1_35.SetActive(true);
                star2_35.SetActive(true); x = x + 2; break;
            case 4:
                star1_35.SetActive(true);
                star3_35.SetActive(true); x = x + 2; break;
            case 5:
                star1_35.SetActive(true);
                star2_35.SetActive(true);
                star3_35.SetActive(true); x = x + 3; break;
        }
        switch (PlayerPrefs.GetInt("lv36"))
        {
            case 2:
                star1_36.SetActive(true); x = x + 1; break;
            case 3:
                star1_36.SetActive(true);
                star2_36.SetActive(true); x = x + 2; break;
            case 4:
                star1_36.SetActive(true);
                star3_36.SetActive(true); x = x + 2; break;
            case 5:
                star1_36.SetActive(true);
                star2_36.SetActive(true);
                star3_36.SetActive(true); x = x + 3; break;
        }
        switch (PlayerPrefs.GetInt("lv37"))
        {
            case 2:
                star1_37.SetActive(true); x = x + 1; break;
            case 3:
                star1_37.SetActive(true);
                star2_37.SetActive(true); x = x + 2; break;
            case 4:
                star1_37.SetActive(true);
                star3_37.SetActive(true); x = x + 2; break;
            case 5:
                star1_37.SetActive(true);
                star2_37.SetActive(true);
                star3_37.SetActive(true); x = x + 3; break;
        }
        switch (PlayerPrefs.GetInt("lv38"))
        {
            case 2:
                star1_38.SetActive(true); x = x + 1; break;
            case 3:
                star1_38.SetActive(true);
                star2_38.SetActive(true); x = x + 2; break;
            case 4:
                star1_38.SetActive(true);
                star3_38.SetActive(true); x = x + 2; break;
            case 5:
                star1_38.SetActive(true);
                star2_38.SetActive(true);
                star3_38.SetActive(true); x = x + 3; break;
        }
        switch (PlayerPrefs.GetInt("lv39"))
        {
            case 2:
                star1_39.SetActive(true); x = x + 1; break;
            case 3:
                star1_39.SetActive(true);
                star2_39.SetActive(true); x = x + 2; break;
            case 4:
                star1_39.SetActive(true);
                star3_39.SetActive(true); x = x + 2; break;
            case 5:
                star1_39.SetActive(true);
                star2_39.SetActive(true);
                star3_39.SetActive(true); x = x + 3; break;
        }
        switch (PlayerPrefs.GetInt("lv40"))
        {
            case 2:
                star1_40.SetActive(true); x = x + 1; break;
            case 3:
                star1_40.SetActive(true);
                star2_40.SetActive(true); x = x + 2; break;
            case 4:
                star1_40.SetActive(true);
                star3_40.SetActive(true); x = x + 2; break;
            case 5:
                star1_40.SetActive(true);
                star2_40.SetActive(true);
                star3_40.SetActive(true); x = x + 3; break;
        }
        switch (PlayerPrefs.GetInt("lv41"))
        {
            case 2:
                star1_41.SetActive(true); x = x + 1; break;
            case 3:
                star1_41.SetActive(true);
                star2_41.SetActive(true); x = x + 2; break;
            case 4:
                star1_41.SetActive(true);
                star3_41.SetActive(true); x = x + 2; break;
            case 5:
                star1_41.SetActive(true);
                star2_41.SetActive(true);
                star3_41.SetActive(true); x = x + 3; break;
        }
        switch (PlayerPrefs.GetInt("lv42"))
        {
            case 2:
                star1_42.SetActive(true); x = x + 1; break;
            case 3:
                star1_42.SetActive(true);
                star2_42.SetActive(true); x = x + 2; break;
            case 4:
                star1_42.SetActive(true);
                star3_42.SetActive(true); x = x + 2; break;
            case 5:
                star1_42.SetActive(true);
                star2_42.SetActive(true);
                star3_42.SetActive(true); x = x + 3; break;
        }
        switch (PlayerPrefs.GetInt("lv43"))
        {
            case 2:
                star1_43.SetActive(true); x = x + 1; break;
            case 3:
                star1_43.SetActive(true);
                star2_43.SetActive(true); x = x + 2; break;
            case 4:
                star1_43.SetActive(true);
                star3_43.SetActive(true); x = x + 2; break;
            case 5:
                star1_43.SetActive(true);
                star2_43.SetActive(true);
                star3_43.SetActive(true); x = x + 3; break;
        }
        switch (PlayerPrefs.GetInt("lv44"))
        {
            case 2:
                star1_44.SetActive(true); x = x + 1; break;
            case 3:
                star1_44.SetActive(true);
                star2_44.SetActive(true); x = x + 2; break;
            case 4:
                star1_44.SetActive(true);
                star3_44.SetActive(true); x = x + 2; break;
            case 5:
                star1_44.SetActive(true);
                star2_44.SetActive(true);
                star3_44.SetActive(true); x = x + 3; break;
        }
        switch (PlayerPrefs.GetInt("lv45"))
        {
            case 2:
                star1_45.SetActive(true); x = x + 1; break;
            case 3:
                star1_45.SetActive(true);
                star2_45.SetActive(true); x = x + 2; break;
            case 4:
                star1_45.SetActive(true);
                star3_45.SetActive(true); x = x + 2; break;
            case 5:
                star1_45.SetActive(true);
                star2_45.SetActive(true);
                star3_45.SetActive(true); x = x + 3; break;
        }
        switch (PlayerPrefs.GetInt("lv46"))
        {
            case 2:
                star1_46.SetActive(true); x = x + 1; break;
            case 3:
                star1_46.SetActive(true);
                star2_46.SetActive(true); x = x + 2; break;
            case 4:
                star1_46.SetActive(true);
                star3_46.SetActive(true); x = x + 2; break;
            case 5:
                star1_46.SetActive(true);
                star2_46.SetActive(true);
                star3_46.SetActive(true); x = x + 3; break;
        }
        switch (PlayerPrefs.GetInt("lv47"))
        {
            case 2:
                star1_47.SetActive(true); x = x + 1; break;
            case 3:
                star1_47.SetActive(true);
                star2_47.SetActive(true); x = x + 2; break;
            case 4:
                star1_47.SetActive(true);
                star3_47.SetActive(true); x = x + 2; break;
            case 5:
                star1_47.SetActive(true);
                star2_47.SetActive(true);
                star3_47.SetActive(true); x = x + 3; break;
        }
        switch (PlayerPrefs.GetInt("lv48"))
        {
            case 2:
                star1_48.SetActive(true); x = x + 1; break;
            case 3:
                star1_48.SetActive(true);
                star2_48.SetActive(true); x = x + 2; break;
            case 4:
                star1_48.SetActive(true);
                star3_48.SetActive(true); x = x + 2; break;
            case 5:
                star1_48.SetActive(true);
                star2_48.SetActive(true);
                star3_48.SetActive(true); x = x + 3; break;
        }
        switch (PlayerPrefs.GetInt("lv49"))
        {
            case 2:
                star1_49.SetActive(true); x = x + 1; break;
            case 3:
                star1_49.SetActive(true);
                star2_49.SetActive(true); x = x + 2; break;
            case 4:
                star1_49.SetActive(true);
                star3_49.SetActive(true); x = x + 2; break;
            case 5:
                star1_49.SetActive(true);
                star2_49.SetActive(true);
                star3_49.SetActive(true); x = x + 3; break;
        }
        switch (PlayerPrefs.GetInt("lv50"))
        {
            case 2:
                star1_50.SetActive(true); x = x + 1; break;
            case 3:
                star1_50.SetActive(true);
                star2_50.SetActive(true); x = x + 2; break;
            case 4:
                star1_50.SetActive(true);
                star3_50.SetActive(true); x = x + 2; break;
            case 5:
                star1_50.SetActive(true);
                star2_50.SetActive(true);
                star3_50.SetActive(true); x = x + 3; break;
        }
        switch (PlayerPrefs.GetInt("lv51"))
        {
            case 2:
                star1_51.SetActive(true); x = x + 1; break;
            case 3:
                star1_51.SetActive(true);
                star2_51.SetActive(true); x = x + 2; break;
            case 4:
                star1_51.SetActive(true);
                star3_51.SetActive(true); x = x + 2; break;
            case 5:
                star1_51.SetActive(true);
                star2_51.SetActive(true);
                star3_51.SetActive(true); x = x + 3; break;
        }
        switch (PlayerPrefs.GetInt("lv52"))
        {
            case 2:
                star1_52.SetActive(true); x = x + 1; break;
            case 3:
                star1_52.SetActive(true);
                star2_52.SetActive(true); x = x + 2; break;
            case 4:
                star1_52.SetActive(true);
                star3_52.SetActive(true); x = x + 2; break;
            case 5:
                star1_52.SetActive(true);
                star2_52.SetActive(true);
                star3_52.SetActive(true); x = x + 3; break;
        }
        switch (PlayerPrefs.GetInt("lv53"))
        {
            case 2:
                star1_53.SetActive(true); x = x + 1; break;
            case 3:
                star1_53.SetActive(true);
                star2_53.SetActive(true); x = x + 2; break;
            case 4:
                star1_53.SetActive(true);
                star3_53.SetActive(true); x = x + 2; break;
            case 5:
                star1_53.SetActive(true);
                star2_53.SetActive(true);
                star3_53.SetActive(true); x = x + 3; break;
        }
        switch (PlayerPrefs.GetInt("lv54"))
        {
            case 2:
                star1_54.SetActive(true); x = x + 1; break;
            case 3:
                star1_54.SetActive(true);
                star2_54.SetActive(true); x = x + 2; break;
            case 4:
                star1_54.SetActive(true);
                star3_54.SetActive(true); x = x + 2; break;
            case 5:
                star1_54.SetActive(true);
                star2_54.SetActive(true);
                star3_54.SetActive(true); x = x + 3; break;
        }
        switch (PlayerPrefs.GetInt("lv55"))
        {
            case 2:
                star1_55.SetActive(true); x = x + 1; break;
            case 3:
                star1_55.SetActive(true);
                star2_55.SetActive(true); x = x + 2; break;
            case 4:
                star1_55.SetActive(true);
                star3_55.SetActive(true); x = x + 2; break;
            case 5:
                star1_55.SetActive(true);
                star2_55.SetActive(true);
                star3_55.SetActive(true); x = x + 3; break;
        }
        switch (PlayerPrefs.GetInt("lv56"))
        {
            case 2:
                star1_56.SetActive(true); x = x + 1; break;
            case 3:
                star1_56.SetActive(true);
                star2_56.SetActive(true); x = x + 2; break;
            case 4:
                star1_56.SetActive(true);
                star3_56.SetActive(true); x = x + 2; break;
            case 5:
                star1_56.SetActive(true);
                star2_56.SetActive(true);
                star3_56.SetActive(true); x = x + 3; break;
        }
        switch (PlayerPrefs.GetInt("lv57"))
        {
            case 2:
                star1_57.SetActive(true); x = x + 1; break;
            case 3:
                star1_57.SetActive(true);
                star2_57.SetActive(true); x = x + 2; break;
            case 4:
                star1_57.SetActive(true);
                star3_57.SetActive(true); x = x + 2; break;
            case 5:
                star1_57.SetActive(true);
                star2_57.SetActive(true);
                star3_57.SetActive(true); x = x + 3; break;
        }
        switch (PlayerPrefs.GetInt("lv58"))
        {
            case 2:
                star1_58.SetActive(true); x = x + 1; break;
            case 3:
                star1_58.SetActive(true);
                star2_58.SetActive(true); x = x + 2; break;
            case 4:
                star1_58.SetActive(true);
                star3_58.SetActive(true); x = x + 2; break;
            case 5:
                star1_58.SetActive(true);
                star2_58.SetActive(true);
                star3_58.SetActive(true); x = x + 3; break;
        }
        switch (PlayerPrefs.GetInt("lv59"))
        {
            case 2:
                star1_59.SetActive(true); x = x + 1; break;
            case 3:
                star1_59.SetActive(true);
                star2_59.SetActive(true); x = x + 2; break;
            case 4:
                star1_59.SetActive(true);
                star3_59.SetActive(true); x = x + 2; break;
            case 5:
                star1_59.SetActive(true);
                star2_59.SetActive(true);
                star3_59.SetActive(true); x = x + 3; break;
        }
        switch (PlayerPrefs.GetInt("lv60"))
        {
            case 2:
                star1_60.SetActive(true); x = x + 1; break;
            case 3:
                star1_60.SetActive(true);
                star2_60.SetActive(true); x = x + 2; break;
            case 4:
                star1_60.SetActive(true);
                star3_60.SetActive(true); x = x + 2; break;
            case 5:
                star1_60.SetActive(true);
                star2_60.SetActive(true);
                star3_60.SetActive(true); x = x + 3; break;
        }
        switch (PlayerPrefs.GetInt("lv61"))
        {
            case 2:
                star1_61.SetActive(true); x = x + 1; break;
            case 3:
                star1_61.SetActive(true);
                star2_61.SetActive(true); x = x + 2; break;
            case 4:
                star1_61.SetActive(true);
                star3_61.SetActive(true); x = x + 2; break;
            case 5:
                star1_61.SetActive(true);
                star2_61.SetActive(true);
                star3_61.SetActive(true); x = x + 3; break;
        }
        switch (PlayerPrefs.GetInt("lv62"))
        {
            case 2:
                star1_62.SetActive(true); x = x + 1; break;
            case 3:
                star1_62.SetActive(true);
                star2_62.SetActive(true); x = x + 2; break;
            case 4:
                star1_62.SetActive(true);
                star3_62.SetActive(true); x = x + 2; break;
            case 5:
                star1_62.SetActive(true);
                star2_62.SetActive(true);
                star3_62.SetActive(true); x = x + 3; break;
        }
        switch (PlayerPrefs.GetInt("lv63"))
        {
            case 2:
                star1_63.SetActive(true); x = x + 1; break;
            case 3:
                star1_63.SetActive(true);
                star2_63.SetActive(true); x = x + 2; break;
            case 4:
                star1_63.SetActive(true);
                star3_63.SetActive(true); x = x + 2; break;
            case 5:
                star1_63.SetActive(true);
                star2_63.SetActive(true);
                star3_63.SetActive(true); x = x + 3; break;
        }
        switch (PlayerPrefs.GetInt("lv64"))
        {
            case 2:
                star1_64.SetActive(true); x = x + 1; break;
            case 3:
                star1_64.SetActive(true);
                star2_64.SetActive(true); x = x + 2; break;
            case 4:
                star1_64.SetActive(true);
                star3_64.SetActive(true); x = x + 2; break;
            case 5:
                star1_64.SetActive(true);
                star2_64.SetActive(true);
                star3_64.SetActive(true); x = x + 3; break;
        }
        switch (PlayerPrefs.GetInt("lv65"))
        {
            case 2:
                star1_65.SetActive(true); x = x + 1; break;
            case 3:
                star1_65.SetActive(true);
                star2_65.SetActive(true); x = x + 2; break;
            case 4:
                star1_65.SetActive(true);
                star3_65.SetActive(true); x = x + 2; break;
            case 5:
                star1_65.SetActive(true);
                star2_65.SetActive(true);
                star3_65.SetActive(true); x = x + 3; break;
        }
        switch (PlayerPrefs.GetInt("lv66"))
        {
            case 2:
                star1_66.SetActive(true); x = x + 1; break;
            case 3:
                star1_66.SetActive(true);
                star2_66.SetActive(true); x = x + 2; break;
            case 4:
                star1_66.SetActive(true);
                star3_66.SetActive(true); x = x + 2; break;
            case 5:
                star1_66.SetActive(true);
                star2_66.SetActive(true);
                star3_66.SetActive(true); x = x + 3; break;
        }
        switch (PlayerPrefs.GetInt("lv67"))
        {
            case 2:
                star1_67.SetActive(true); x = x + 1; break;
            case 3:
                star1_67.SetActive(true);
                star2_67.SetActive(true); x = x + 2; break;
            case 4:
                star1_67.SetActive(true);
                star3_67.SetActive(true); x = x + 2; break;
            case 5:
                star1_67.SetActive(true);
                star2_67.SetActive(true);
                star3_67.SetActive(true); x = x + 3; break;
        }
        switch (PlayerPrefs.GetInt("lv68"))
        {
            case 2:
                star1_68.SetActive(true); x = x + 1; break;
            case 3:
                star1_68.SetActive(true);
                star2_68.SetActive(true); x = x + 2; break;
            case 4:
                star1_68.SetActive(true);
                star3_68.SetActive(true); x = x + 2; break;
            case 5:
                star1_68.SetActive(true);
                star2_68.SetActive(true);
                star3_68.SetActive(true); x = x + 3; break;
        }
        switch (PlayerPrefs.GetInt("lv69"))
        {
            case 2:
                star1_69.SetActive(true); x = x + 1; break;
            case 3:
                star1_69.SetActive(true);
                star2_69.SetActive(true); x = x + 2; break;
            case 4:
                star1_69.SetActive(true);
                star3_69.SetActive(true); x = x + 2; break;
            case 5:
                star1_69.SetActive(true);
                star2_69.SetActive(true);
                star3_69.SetActive(true); x = x + 3; break;
        }
        switch (PlayerPrefs.GetInt("lv70"))
        {
            case 2:
                star1_70.SetActive(true); x = x + 1; break;
            case 3:
                star1_70.SetActive(true);
                star2_70.SetActive(true); x = x + 2; break;
            case 4:
                star1_70.SetActive(true);
                star3_70.SetActive(true); x = x + 2; break;
            case 5:
                star1_70.SetActive(true);
                star2_70.SetActive(true);
                star3_70.SetActive(true); x = x + 3; break;
        }
        switch (PlayerPrefs.GetInt("lv71"))
        {
            case 2:
                star1_71.SetActive(true); x = x + 1; break;
            case 3:
                star1_71.SetActive(true);
                star2_71.SetActive(true); x = x + 2; break;
            case 4:
                star1_71.SetActive(true);
                star3_71.SetActive(true); x = x + 2; break;
            case 5:
                star1_71.SetActive(true);
                star2_71.SetActive(true);
                star3_71.SetActive(true); x = x + 3; break;
        }
        switch (PlayerPrefs.GetInt("lv72"))
        {
            case 2:
                star1_72.SetActive(true); x = x + 1; break;
            case 3:
                star1_72.SetActive(true);
                star2_72.SetActive(true); x = x + 2; break;
            case 4:
                star1_72.SetActive(true);
                star3_72.SetActive(true); x = x + 2; break;
            case 5:
                star1_72.SetActive(true);
                star2_72.SetActive(true);
                star3_72.SetActive(true); x = x + 3; break;
        }
        switch (PlayerPrefs.GetInt("lv73"))
        {
            case 2:
                star1_73.SetActive(true); x = x + 1; break;
            case 3:
                star1_73.SetActive(true);
                star2_73.SetActive(true); x = x + 2; break;
            case 4:
                star1_73.SetActive(true);
                star3_73.SetActive(true); x = x + 2; break;
            case 5:
                star1_73.SetActive(true);
                star2_73.SetActive(true);
                star3_73.SetActive(true); x = x + 3; break;
        }
        switch (PlayerPrefs.GetInt("lv74"))
        {
            case 2:
                star1_74.SetActive(true); x = x + 1; break;
            case 3:
                star1_74.SetActive(true);
                star2_74.SetActive(true); x = x + 2; break;
            case 4:
                star1_74.SetActive(true);
                star3_74.SetActive(true); x = x + 2; break;
            case 5:
                star1_74.SetActive(true);
                star2_74.SetActive(true);
                star3_74.SetActive(true); x = x + 3; break;
        }
        switch (PlayerPrefs.GetInt("lv75"))
        {
            case 2:
                star1_75.SetActive(true); x = x + 1; break;
            case 3:
                star1_75.SetActive(true);
                star2_75.SetActive(true); x = x + 2; break;
            case 4:
                star1_75.SetActive(true);
                star3_75.SetActive(true); x = x + 2; break;
            case 5:
                star1_75.SetActive(true);
                star2_75.SetActive(true);
                star3_75.SetActive(true); x = x + 3; break;
        }
        switch (PlayerPrefs.GetInt("lv76"))
        {
            case 2:
                star1_76.SetActive(true); x = x + 1; break;
            case 3:
                star1_76.SetActive(true);
                star2_76.SetActive(true); x = x + 2; break;
            case 4:
                star1_76.SetActive(true);
                star3_76.SetActive(true); x = x + 2; break;
            case 5:
                star1_76.SetActive(true);
                star2_76.SetActive(true);
                star3_76.SetActive(true); x = x + 3; break;
        }
        switch (PlayerPrefs.GetInt("lv77"))
        {
            case 2:
                star1_77.SetActive(true); x = x + 1; break;
            case 3:
                star1_77.SetActive(true);
                star2_77.SetActive(true); x = x + 2; break;
            case 4:
                star1_77.SetActive(true);
                star3_77.SetActive(true); x = x + 2; break;
            case 5:
                star1_77.SetActive(true);
                star2_77.SetActive(true);
                star3_77.SetActive(true); x = x + 3; break;
        }
        switch (PlayerPrefs.GetInt("lv78"))
        {
            case 2:
                star1_78.SetActive(true); x = x + 1; break;
            case 3:
                star1_78.SetActive(true);
                star2_78.SetActive(true); x = x + 2; break;
            case 4:
                star1_78.SetActive(true);
                star3_78.SetActive(true); x = x + 2; break;
            case 5:
                star1_78.SetActive(true);
                star2_78.SetActive(true);
                star3_78.SetActive(true); x = x + 3; break;
        }
        switch (PlayerPrefs.GetInt("lv79"))
        {
            case 2:
                star1_79.SetActive(true); x = x + 1; break;
            case 3:
                star1_79.SetActive(true);
                star2_79.SetActive(true); x = x + 2; break;
            case 4:
                star1_79.SetActive(true);
                star3_79.SetActive(true); x = x + 2; break;
            case 5:
                star1_79.SetActive(true);
                star2_79.SetActive(true);
                star3_79.SetActive(true); x = x + 3; break;
        }
        switch (PlayerPrefs.GetInt("lv80"))
        {
            case 2:
                star1_80.SetActive(true); x = x + 1; break;
            case 3:
                star1_80.SetActive(true);
                star2_80.SetActive(true); x = x + 2; break;
            case 4:
                star1_80.SetActive(true);
                star3_80.SetActive(true); x = x + 2; break;
            case 5:
                star1_80.SetActive(true);
                star2_80.SetActive(true);
                star3_80.SetActive(true); x = x + 3; break;
        }
        switch (PlayerPrefs.GetInt("lv81"))
        {
            case 2:
                star1_81.SetActive(true); x = x + 1; break;
            case 3:
                star1_81.SetActive(true);
                star2_81.SetActive(true); x = x + 2; break;
            case 4:
                star1_81.SetActive(true);
                star3_81.SetActive(true); x = x + 2; break;
            case 5:
                star1_81.SetActive(true);
                star2_81.SetActive(true);
                star3_81.SetActive(true); x = x + 3; break;
        }
        switch (PlayerPrefs.GetInt("lv82"))
        {
            case 2:
                star1_82.SetActive(true); x = x + 1; break;
            case 3:
                star1_82.SetActive(true);
                star2_82.SetActive(true); x = x + 2; break;
            case 4:
                star1_82.SetActive(true);
                star3_82.SetActive(true); x = x + 2; break;
            case 5:
                star1_82.SetActive(true);
                star2_82.SetActive(true);
                star3_82.SetActive(true); x = x + 3; break;
        }
        switch (PlayerPrefs.GetInt("lv83"))
        {
            case 2:
                star1_83.SetActive(true); x = x + 1; break;
            case 3:
                star1_83.SetActive(true);
                star2_83.SetActive(true); x = x + 2; break;
            case 4:
                star1_83.SetActive(true);
                star3_83.SetActive(true); x = x + 2; break;
            case 5:
                star1_83.SetActive(true);
                star2_83.SetActive(true);
                star3_83.SetActive(true); x = x + 3; break;
        }
        switch (PlayerPrefs.GetInt("lv84"))
        {
            case 2:
                star1_84.SetActive(true); x = x + 1; break;
            case 3:
                star1_84.SetActive(true);
                star2_84.SetActive(true); x = x + 2; break;
            case 4:
                star1_84.SetActive(true);
                star3_84.SetActive(true); x = x + 2; break;
            case 5:
                star1_84.SetActive(true);
                star2_84.SetActive(true);
                star3_84.SetActive(true); x = x + 3; break;
        }
        switch (PlayerPrefs.GetInt("lv85"))
        {
            case 2:
                star1_85.SetActive(true); x = x + 1; break;
            case 3:
                star1_85.SetActive(true);
                star2_85.SetActive(true); x = x + 2; break;
            case 4:
                star1_85.SetActive(true);
                star3_85.SetActive(true); x = x + 2; break;
            case 5:
                star1_85.SetActive(true);
                star2_85.SetActive(true);
                star3_85.SetActive(true); x = x + 3; break;
        }
        switch (PlayerPrefs.GetInt("lv86"))
        {
            case 2:
                star1_86.SetActive(true); x = x + 1; break;
            case 3:
                star1_86.SetActive(true);
                star2_86.SetActive(true); x = x + 2; break;
            case 4:
                star1_86.SetActive(true);
                star3_86.SetActive(true); x = x + 2; break;
            case 5:
                star1_86.SetActive(true);
                star2_86.SetActive(true);
                star3_86.SetActive(true); x = x + 3; break;
        }
        switch (PlayerPrefs.GetInt("lv87"))
        {
            case 2:
                star1_87.SetActive(true); x = x + 1; break;
            case 3:
                star1_87.SetActive(true);
                star2_87.SetActive(true); x = x + 2; break;
            case 4:
                star1_87.SetActive(true);
                star3_87.SetActive(true); x = x + 2; break;
            case 5:
                star1_87.SetActive(true);
                star2_87.SetActive(true);
                star3_87.SetActive(true); x = x + 3; break;
        }
        switch (PlayerPrefs.GetInt("lv88"))
        {
            case 2:
                star1_88.SetActive(true); x = x + 1; break;
            case 3:
                star1_88.SetActive(true);
                star2_88.SetActive(true); x = x + 2; break;
            case 4:
                star1_88.SetActive(true);
                star3_88.SetActive(true); x = x + 2; break;
            case 5:
                star1_88.SetActive(true);
                star2_88.SetActive(true);
                star3_88.SetActive(true); x = x + 3; break;
        }
        switch (PlayerPrefs.GetInt("lv89"))
        {
            case 2:
                star1_89.SetActive(true); x = x + 1; break;
            case 3:
                star1_89.SetActive(true);
                star2_89.SetActive(true); x = x + 2; break;
            case 4:
                star1_89.SetActive(true);
                star3_89.SetActive(true); x = x + 2; break;
            case 5:
                star1_89.SetActive(true);
                star2_89.SetActive(true);
                star3_89.SetActive(true); x = x + 3; break;
        }
        switch (PlayerPrefs.GetInt("lv90"))
        {
            case 2:
                star1_90.SetActive(true); x = x + 1; break;
            case 3:
                star1_90.SetActive(true);
                star2_90.SetActive(true); x = x + 2; break;
            case 4:
                star1_90.SetActive(true);
                star3_90.SetActive(true); x = x + 2; break;
            case 5:
                star1_90.SetActive(true);
                star2_90.SetActive(true);
                star3_90.SetActive(true); x = x + 3; break;
        }
        switch (PlayerPrefs.GetInt("lv91"))
        {
            case 2:
                star1_91.SetActive(true); x = x + 1; break;
            case 3:
                star1_91.SetActive(true);
                star2_91.SetActive(true); x = x + 2; break;
            case 4:
                star1_91.SetActive(true);
                star3_91.SetActive(true); x = x + 2; break;
            case 5:
                star1_91.SetActive(true);
                star2_91.SetActive(true);
                star3_91.SetActive(true); x = x + 3; break;
        }
        switch (PlayerPrefs.GetInt("lv92"))
        {
            case 2:
                star1_92.SetActive(true); x = x + 1; break;
            case 3:
                star1_92.SetActive(true);
                star2_92.SetActive(true); x = x + 2; break;
            case 4:
                star1_92.SetActive(true);
                star3_92.SetActive(true); x = x + 2; break;
            case 5:
                star1_92.SetActive(true);
                star2_92.SetActive(true);
                star3_92.SetActive(true); x = x + 3; break;
        }
        switch (PlayerPrefs.GetInt("lv93"))
        {
            case 2:
                star1_93.SetActive(true); x = x + 1; break;
            case 3:
                star1_93.SetActive(true);
                star2_93.SetActive(true); x = x + 2; break;
            case 4:
                star1_93.SetActive(true);
                star3_93.SetActive(true); x = x + 2; break;
            case 5:
                star1_93.SetActive(true);
                star2_93.SetActive(true);
                star3_93.SetActive(true); x = x + 3; break;
        }
        switch (PlayerPrefs.GetInt("lv94"))
        {
            case 2:
                star1_94.SetActive(true); x = x + 1; break;
            case 3:
                star1_94.SetActive(true);
                star2_94.SetActive(true); x = x + 2; break;
            case 4:
                star1_94.SetActive(true);
                star3_94.SetActive(true); x = x + 2; break;
            case 5:
                star1_94.SetActive(true);
                star2_94.SetActive(true);
                star3_94.SetActive(true); x = x + 3; break;
        }
        switch (PlayerPrefs.GetInt("lv95"))
        {
            case 2:
                star1_95.SetActive(true); x = x + 1; break;
            case 3:
                star1_95.SetActive(true);
                star2_95.SetActive(true); x = x + 2; break;
            case 4:
                star1_95.SetActive(true);
                star3_95.SetActive(true); x = x + 2; break;
            case 5:
                star1_95.SetActive(true);
                star2_95.SetActive(true);
                star3_95.SetActive(true); x = x + 3; break;
        }
        switch (PlayerPrefs.GetInt("lv96"))
        {
            case 2:
                star1_96.SetActive(true); x = x + 1; break;
            case 3:
                star1_96.SetActive(true);
                star2_96.SetActive(true); x = x + 2; break;
            case 4:
                star1_96.SetActive(true);
                star3_96.SetActive(true); x = x + 2; break;
            case 5:
                star1_96.SetActive(true);
                star2_96.SetActive(true);
                star3_96.SetActive(true); x = x + 3; break;
        }
        switch (PlayerPrefs.GetInt("lv97"))
        {
            case 2:
                star1_97.SetActive(true); x = x + 1; break;
            case 3:
                star1_97.SetActive(true);
                star2_97.SetActive(true); x = x + 2; break;
            case 4:
                star1_97.SetActive(true);
                star3_97.SetActive(true); x = x + 2; break;
            case 5:
                star1_97.SetActive(true);
                star2_97.SetActive(true);
                star3_97.SetActive(true); x = x + 3; break;
        }
        switch (PlayerPrefs.GetInt("lv98"))
        {
            case 2:
                star1_98.SetActive(true); x = x + 1; break;
            case 3:
                star1_98.SetActive(true);
                star2_98.SetActive(true); x = x + 2; break;
            case 4:
                star1_98.SetActive(true);
                star3_98.SetActive(true); x = x + 2; break;
            case 5:
                star1_98.SetActive(true);
                star2_98.SetActive(true);
                star3_98.SetActive(true); x = x + 3; break;
        }
        switch (PlayerPrefs.GetInt("lv99"))
        {
            case 2:
                star1_99.SetActive(true); x = x + 1; break;
            case 3:
                star1_99.SetActive(true);
                star2_99.SetActive(true); x = x + 2; break;
            case 4:
                star1_99.SetActive(true);
                star3_99.SetActive(true); x = x + 2; break;
            case 5:
                star1_99.SetActive(true);
                star2_99.SetActive(true);
                star3_99.SetActive(true); x = x + 3; break;
        }
        switch (PlayerPrefs.GetInt("lv100"))
        {
            case 2:
                star1_100.SetActive(true); x = x + 1; break;
            case 3:
                star1_100.SetActive(true);
                star2_100.SetActive(true); x = x + 2; break;
            case 4:
                star1_100.SetActive(true);
                star3_100.SetActive(true); x = x + 2; break;
            case 5:
                star1_100.SetActive(true);
                star2_100.SetActive(true);
                star3_100.SetActive(true); x = x + 3; break;
        }
        switch (PlayerPrefs.GetInt("lv101"))
        {
            case 2:
                star1_101.SetActive(true); break;
            case 3:
                star1_101.SetActive(true);
                star2_101.SetActive(true); break;
            case 4:
                star1_101.SetActive(true);
                star3_101.SetActive(true); break;
            case 5:
                star1_101.SetActive(true);
                star2_101.SetActive(true);
                star3_101.SetActive(true); break;
        }
        text.text = text.text + x.ToString();
    }
}