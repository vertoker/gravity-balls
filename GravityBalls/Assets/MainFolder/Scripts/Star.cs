using UnityEngine;

public class Star : MonoBehaviour
{
    public GameObject isStar;
    public GameObject Effect;

    public void OnTriggerEnter2D(Collider2D collision)
    {
        switch (collision.tag)
        {
            case "Player":
                Instantiate(Effect, transform.position, Quaternion.identity);
                isStar.SetActive(true);
                Destroy(gameObject);
                break;
        }
    }
}
