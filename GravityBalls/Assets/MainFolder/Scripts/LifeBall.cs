using System.Collections;
using UnityEngine;

public class LifeBall : MonoBehaviour
{
    public float Deletetime;

    public void OnTriggerEnter2D(Collider2D collision)
    {
        switch (collision.tag)
        {
            case "Dead":
                StartCoroutine(Deleteenumerator());
                break;
            case "DeadBall":
                StartCoroutine(Deleteenumerator());
                break;
            case "DeadBall2":
                StartCoroutine(Deleteenumerator());
                break;
        }
    }

    public IEnumerator Deleteenumerator()
    {
        yield return new WaitForSeconds(Deletetime);
        Destroy(gameObject);
    }
}
