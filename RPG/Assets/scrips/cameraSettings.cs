using UnityEngine;
using System.Collections.Generic;
using System.Threading.Tasks;

public class cameraSettings : playerManager
{
    public Transform target;
    private void FixedUpdate()
    {
        { transform.position = Vector2.MoveTowards(transform.position, target.position, speed * Time.fixedDeltaTime); }
    }
}
