using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class follow : MonoBehaviour
{
    public Camera cam;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
            Vector3 destination = transform.position + new Vector3(0, 0, -10);
        if (cam)
            cam.transform.position = Vector3.Lerp(cam.transform.position, destination, 0.9f);
            
    }
}
