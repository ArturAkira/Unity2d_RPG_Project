using UnityEngine;

public class cameraSettings : playerManager
{
    private bool camScene;
    public Transform target;
    void Start()
    {
        camScene = true;
    }

    void Update()
    {
        camerafollow();
    }

    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.CompareTag("Player") == true)
        {
            camScene = true;
        }
    }
    private void OnTriggerExit2D(Collider2D col)
    {
        if (col.CompareTag("Player") == true)
        {
            camScene = false;
        }
    }

    private void camerafollow()
    {
        if (camScene == false)
        {
            transform.position = Vector2.MoveTowards(transform.position,target.position,speed * Time.deltaTime);
        }
    }
}
