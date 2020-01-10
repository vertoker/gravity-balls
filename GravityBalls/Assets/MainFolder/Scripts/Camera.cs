using UnityEngine;

public class Camera : MonoBehaviour
{
    public void Awake()
    {
        CameraWork();
    }

    public void FixedUpdate()
    {
        CameraWork();
    }

    public void Update()
    {
        CameraWork();
    }

    public void CameraWork()
    {
        if (GameObject.FindWithTag("Player"))
        {
            transform.position = new Vector3(GameObject.FindWithTag("Player").transform.position.x,
                GameObject.FindWithTag("Player").transform.position.y, -10f);
        }
    }
}