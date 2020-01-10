using System.Collections;
using UnityEngine;

public class Destroy : MonoBehaviour
{
    public void Start()
    {
        StartCoroutine(DestroyCoroutine());
    }

    public IEnumerator DestroyCoroutine()
    {
        yield return new WaitForSeconds(0.5f);
        Destroy(gameObject);
    }
}
