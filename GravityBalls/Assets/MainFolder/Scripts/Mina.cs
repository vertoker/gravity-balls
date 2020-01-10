using UnityEngine;

public class Mina : MonoBehaviour
{
    public GameObject objEffect;
    public GameObject ExpEnd;

    public void OnTriggerEnter2D(Collider2D collision)
    {
        switch (collision.tag)
        {
            case "Player":
                Instantiate(objEffect, new Vector3(transform.position.x,
                    transform.position.y, -1.5f), transform.rotation);
                Instantiate(ExpEnd, transform);
                Destroy(gameObject);
                break;
        }
    }
}
