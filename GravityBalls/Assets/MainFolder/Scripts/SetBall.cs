using System.Collections;
using UnityEngine;

public class SetBall : MonoBehaviour
{
    public int metod;
    public int objint;
    public GameObject deathball;
    public GameObject death;
    public GameObject lifeball;
    [Header("Metod1")]
    public float TimeSec1;
    [Header("Metod2")]
    public float TimeSec2;

    public void Start()
    {
        switch (metod)
        {
            case 1: StartCoroutine(EnumeratorMetod1()); break;
            case 2: StartCoroutine(EnumeratorMetod2()); break;
        }
    }

    public IEnumerator EnumeratorMetod1()
    {
        yield return new WaitForSeconds(TimeSec1);
        switch (objint)
        {
            case 1: Instantiate(deathball, transform); break;
            case 2: Instantiate(death, transform); break;
            case 3: Instantiate(lifeball, transform); break;
        }
        Start();
    }

    public IEnumerator EnumeratorMetod2()
    {
        yield return new WaitForSeconds(TimeSec2);
        if (!GameObject.FindWithTag("DeadBall") || !GameObject.FindWithTag("DeathBall") || !GameObject.FindWithTag("LifeBall"))
        {
            switch (objint)
            {
                case 1: Instantiate(deathball, transform); break;
                case 2: Instantiate(death, transform); break;
                case 3: Instantiate(lifeball, transform); break;
            }
        }
        Start();
    }
}
