using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraScript : MonoBehaviour
{
    public float rotationAngle = 90;
    public float turnSpeed = 0.01f;
    public bool infiniteTurn;
    public bool startTurnRight;
    public bool turnedOn = true;
    GameObject camLight;

    float turnPosition;
    float appliedTurnSpeed;
    // Start is called before the first frame update
    private void Awake()
    {
        camLight = transform.GetChild(0).gameObject;
    }
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
        camLight.SetActive(turnedOn);
        if(turnedOn)
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
