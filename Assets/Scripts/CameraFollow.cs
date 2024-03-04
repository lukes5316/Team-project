using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public GameObject player;
    private Vector3 defaultOffset = new Vector3(0, 5, -10);
    private Vector3 driverOffset = new Vector3(0, 2.28f, 0.35f);

    private KeyCode switchPerspective = KeyCode.Z;

    private bool isDriverPerspective = false;
    
    void Update()
    {
        if(Input.GetKeyDown(switchPerspective))
        {
            isDriverPerspective = !isDriverPerspective;            
        }
        
        
    }
    private void LateUpdate()
    {
        Vector3 targetOffset = isDriverPerspective ? driverOffset : defaultOffset;
        transform.position = player.transform.position + targetOffset;
    }
}
