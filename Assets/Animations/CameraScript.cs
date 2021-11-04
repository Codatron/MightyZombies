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
public class CameraMovement : MonoBehaviour
{
	//public GameObject MovingCamera = null;
	
	public float xMove = 5;
	public float yMove = 5;
	public float cameraVelocity = 0.1f;
	//public int cameraDirection = 1;
	
    // Start is called before the first frame update
    void Start()
    {
        //Vector3 cameraPosition = new Vector3;
    }

    // Update is called once per frame
    void Update()
    {
        for (float x = 0; x <= xMove; x = x + cameraVelocity)
		{
			transform.position = transform.position + new Vector3(x, 0, 0); 
		}
		for (float y = 0; y <= yMove; y = y + cameraVelocity)
		{
			
		}
    }
}
