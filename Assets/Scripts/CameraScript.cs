using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraScript : MonoBehaviour
{
    public float rotationAngle = 90;
    public float turnSpeed = 0.01f;
    public bool infiniteTurn;
    public bool startTurnRight;

    float turnPosition;
    float appliedTurnSpeed;
    // Start is called before the first frame update
    void Start()
    {
        if(startTurnRight)
            appliedTurnSpeed = turnSpeed;
        else
            appliedTurnSpeed = -turnSpeed;
    }

    // Update is called once per frame
    void Update()
    {
        if(!infiniteTurn)
        {
            transform.Rotate(new Vector3(0, 0, appliedTurnSpeed));
            turnPosition += appliedTurnSpeed;
            if (Mathf.Abs(turnPosition) > rotationAngle / 2)
                appliedTurnSpeed *= -1;
        }
        else
            transform.Rotate(new Vector3(0, 0, appliedTurnSpeed));

    }
}
