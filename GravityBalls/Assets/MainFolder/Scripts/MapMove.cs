using UnityEngine;
using System.Collections;

public class MapMove : MonoBehaviour
{
    public GameObject questionsobj;
    public GameObject resetobj;
    private float sec = 0.1f;

    public void Left()
    {
        transform.Rotate(0, 0, 30f);
        questionsobj.SetActive(false);
        resetobj.SetActive(false);
        //StartCoroutine(LeftIEnumerator());
    }

    public void Right()
    {
        transform.Rotate(0, 0, -30f);
        questionsobj.SetActive(false);
        resetobj.SetActive(false);
        //StartCoroutine(RightIEnumerator());
    }

    public IEnumerator LeftIEnumerator()
    {
        yield return new WaitForSeconds(sec);
        transform.Rotate(0, 0, 30f);
    }

    public IEnumerator RightIEnumerator()
    {
        yield return new WaitForSeconds(sec);
        transform.Rotate(0, 0, -30f);
    }
}
