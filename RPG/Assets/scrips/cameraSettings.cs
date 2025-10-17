using UnityEngine;
using System.Collections.Generic;
using System.Threading.Tasks;

public class cameraSettings : playerManager
{
    private bool camScene;
    public Transform target;
    void Start()
    {
        camScene = true;
    }

    private void FixedUpdate()
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
            transform.position = Vector2.MoveTowards(transform.position,target.position,speed * Time.fixedDeltaTime);
        }
    }
}
