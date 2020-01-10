using System.Collections;
using UnityEngine;

public class Ball : MonoBehaviour
{
    private bool isTeleported;
    public GameObject inttrans;
    public Transform[] trans;
    public float TimeSec;
    public GameObject effectteleport;
    public GameObject isWin;
    public GameObject isLose;
    public GameObject isFinished;
    public Ads ads;

    public void Start()
    {
        isWin.SetActive(false);
        isLose.SetActive(false);
        isFinished.SetActive(false);
        isTeleported = false;
        ads = GameObject.FindWithTag("MainCamera").AddComponent<Ads>();
        for (int x = 0; x < int.Parse(inttrans.name); x++)
        {
            trans[x] = GameObject.FindWithTag("Teleport" + (x + 1).ToString()).transform;
        }
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        switch (collision.tag)
        {
            case "DeadBall":
            case "DeadBall2":
            case "Dead":
            case "Mina":
                if (isFinished.activeSelf == false)
                {
                    ads.AdsVoid();
                    isFinished.SetActive(true);
                    PlayerPrefs.SetInt("Losses", PlayerPrefs.GetInt("Losses") + 1);
                    Destroy(gameObject);
                }
                break;
            case "Finish":
                if (isFinished.activeSelf == false)
                {
                    isFinished.SetActive(true);
                    StartCoroutine(Win());
                }
                break;
            case "Teleport1":
                if (isTeleported == false)
                {
                    transform.position = trans[1].position;
                    Instantiate(effectteleport, trans[0].position, effectteleport.transform.rotation);
                    Instantiate(effectteleport, trans[1].position, effectteleport.transform.rotation);
                    StartCoroutine(EffectTeleportDelete());
                    isTeleported = true;
                }
                StartCoroutine(TelepCoroutine());
                break;
            case "Teleport2":
                if (isTeleported == false)
                {
                    transform.position = trans[0].position;
                    Instantiate(effectteleport, trans[0].position, effectteleport.transform.rotation);
                    Instantiate(effectteleport, trans[1].position, effectteleport.transform.rotation);
                    StartCoroutine(EffectTeleportDelete());
                    isTeleported = true;
                }
                StartCoroutine(TelepCoroutine());
                break;
            case "Teleport3":
                if (isTeleported == false)
                {
                    transform.position = trans[3].position;
                    Instantiate(effectteleport, trans[2].position, effectteleport.transform.rotation);
                    Instantiate(effectteleport, trans[3].position, effectteleport.transform.rotation);
                    StartCoroutine(EffectTeleportDelete());
                    isTeleported = true;
                }
                StartCoroutine(TelepCoroutine());
                break;
            case "Teleport4":
                if (isTeleported == false)
                {
                    transform.position = trans[2].position;
                    Instantiate(effectteleport, trans[2].position, effectteleport.transform.rotation);
                    Instantiate(effectteleport, trans[3].position, effectteleport.transform.rotation);
                    StartCoroutine(EffectTeleportDelete());
                    isTeleported = true;
                }
                StartCoroutine(TelepCoroutine());
                break;
            case "Teleport5":
                if (isTeleported == false)
                {
                    transform.position = trans[5].position;
                    Instantiate(effectteleport, trans[4].position, effectteleport.transform.rotation);
                    Instantiate(effectteleport, trans[5].position, effectteleport.transform.rotation);
                    StartCoroutine(EffectTeleportDelete());
                    isTeleported = true;
                }
                StartCoroutine(TelepCoroutine());
                break;
            case "Teleport6":
                if (isTeleported == false)
                {
                    transform.position = trans[4].position;
                    Instantiate(effectteleport, trans[4].position, effectteleport.transform.rotation);
                    Instantiate(effectteleport, trans[5].position, effectteleport.transform.rotation);
                    StartCoroutine(EffectTeleportDelete());
                    isTeleported = true;
                }
                StartCoroutine(TelepCoroutine());
                break;
            case "Teleport7":
                if (isTeleported == false)
                {
                    transform.position = trans[7].position;
                    Instantiate(effectteleport, trans[6].position, effectteleport.transform.rotation);
                    Instantiate(effectteleport, trans[7].position, effectteleport.transform.rotation);
                    StartCoroutine(EffectTeleportDelete());
                    isTeleported = true;
                }
                StartCoroutine(TelepCoroutine());
                break;
            case "Teleport8":
                if (isTeleported == false)
                {
                    transform.position = trans[6].position;
                    Instantiate(effectteleport, trans[6].position, effectteleport.transform.rotation);
                    Instantiate(effectteleport, trans[7].position, effectteleport.transform.rotation);
                    StartCoroutine(EffectTeleportDelete());
                    isTeleported = true;
                }
                StartCoroutine(TelepCoroutine());
                break;
        }
    }

    public IEnumerator Win()
    {
        yield return new WaitForSeconds(0.2f);
        isWin.SetActive(true);
    }

    public IEnumerator Lose()
    {
        yield return new WaitForSeconds(0.2f);
        isLose.SetActive(true);
    }

    public IEnumerator TelepCoroutine()
    {
        yield return new WaitForSeconds(TimeSec);
        isTeleported = false;
    }

    public IEnumerator EffectTeleportDelete()
    {
        yield return new WaitForSeconds(TimeSec);
        if (GameObject.FindWithTag("Effect Teleport"))
        {
            Destroy(GameObject.FindWithTag("Effect Teleport"));
            StartCoroutine(EffectTeleportDelete());
        }
    }
}
