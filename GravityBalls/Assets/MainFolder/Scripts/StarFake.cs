using UnityEngine;

public class StarFake : MonoBehaviour
{
    public GameObject Effect;

    public void OnTriggerEnter2D(Collider2D collision)
    {
        switch (collision.tag)
        {
            case "Player":
                Instantiate(Effect, transform.position, Quaternion.identity);
                Destroy(gameObject);
                break;
        }
    }
}
