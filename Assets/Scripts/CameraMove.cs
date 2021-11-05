using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMove : MonoBehaviour
{
	//public GameObject MovingCamera = null;
		
	public float xMove = 200;
	public float yMove = 200;
	public float cameraVelocity = 0.5f;
	bool xNeg;
	bool yNeg;
	
	float x = 0;
	float y = 0;
	
	int yDir = 0;
	int xDir = 1;
	
	float startposx;
	float startposy;
	
	
    // Start is called before the first frame update
    void Start()
    {
		startposx = transform.position.x;
		startposy = transform.position.y;
		
		if(xMove<0)
        {
			xMove *= -1;
			xNeg = true;
        }
		if (yMove < 0)
		{
			yMove *= -1;
			yNeg = true;
		}
	}

    // Update is called once per frame
    void Update()
    {
        if (xDir == 1 && yDir == 0)
		{
			x = x + cameraVelocity;
			if(xNeg)
				transform.position -=  new Vector3(cameraVelocity * Time.deltaTime, 0, 0); 
			else
				transform.position += new Vector3(cameraVelocity * Time.deltaTime, 0, 0);
		}
		if (transform.position.x >= startposx + xMove && xDir == 1 && yDir == 0)
		{
			xDir = 0;
			yDir = 1;
		}
		if (xDir == 0 && yDir == 1)
		{
			y = y + cameraVelocity;
			if (yNeg)
				transform.position -=  new Vector3(0, cameraVelocity * Time.deltaTime, 0); 
			else
				transform.position += new Vector3(0, cameraVelocity * Time.deltaTime, 0);
		}
		if (transform.position.y >= startposy + yMove && xDir == 0 && yDir == 1)
		{
			xDir = -1;
			yDir = 0;
		}
		
        if (xDir == -1 && yDir == 0)
		{
			x = x - cameraVelocity;
			if(xNeg)
				transform.position -= new Vector3(-cameraVelocity * Time.deltaTime, 0, 0); 
			else
				transform.position += new Vector3(-cameraVelocity * Time.deltaTime, 0, 0);
		}
		if (transform.position.x <= startposx && xDir == -1 && yDir == 0)
		{
			xDir = 0;
			yDir = -1;
		}
		if (xDir == 0 && yDir == -1)
		{
			y = y - cameraVelocity;
			if(yNeg)
				transform.position -= new Vector3(0, -cameraVelocity * Time.deltaTime, 0); 
			else
				transform.position += new Vector3(0, -cameraVelocity * Time.deltaTime, 0);
		}
		if (transform.position.y < startposy && xDir == 0 && yDir == -1)
		{
			xDir = 1;
			yDir = 0;
		}
    }
}
