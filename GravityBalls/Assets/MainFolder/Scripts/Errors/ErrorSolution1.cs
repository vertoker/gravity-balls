using System.Collections;
using UnityEngine;

public class ErrorSolution1 : MonoBehaviour
{
    public GameObject Lose;
    private bool isLose;

    public void Awake()
    {
        isLose = false;
    }

    public void Update()
    {
        if (isLose == false)
        {
            if (!(GameObject.FindWithTag("Player")))
            {
                isLose = true;
                StartCoroutine(Enumerator());
            }
        }
	}

    public IEnumerator Enumerator()
    {
        yield return new WaitForSeconds(0.3f);
        Lose.SetActive(true);
    }
}
