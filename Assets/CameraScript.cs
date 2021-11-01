using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraScript : MonoBehaviour
{

    bool turningRight;
    public float angle = 90;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(!turningRight)
        {
            transform.Rotate(new Vector3(0, 0, +0.1f));
            if (transform.rotation.eulerAngles.z > angle/2 && transform.rotation.eulerAngles.z < 360 -angle/2)
                turningRight = true;
        }
        else
        {
            transform.Rotate(new Vector3(0, 0, -0.1f));
            if (transform.rotation.eulerAngles.z <= 360 - angle / 2 && transform.rotation.eulerAngles.z >= angle / 2)
                turningRight = false;
        }
       Debug.Log(transform.rotation.eulerAngles.z);
    }
}
