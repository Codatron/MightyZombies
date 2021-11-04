using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMove : MonoBehaviour
{
	//public GameObject MovingCamera = null;
		
	public float xMove = 200;
	public float yMove = 200;
	public float cameraVelocity = 0.5f;
	
	public float x = 0;
	public float y = 0;
	
	public int yDir = 0;
	public int xDir = 1;
	
	
    // Start is called before the first frame update
    void Start()
    {
		
    }

    // Update is called once per frame
    void Update()
    {
        if (x < xMove && xDir == 1 && yDir == 0)
		{
			x = x + cameraVelocity;
			transform.position = transform.position + new Vector3(cameraVelocity * Time.deltaTime, 0, 0); 
		}
		if (!(x < xMove) && xDir == 1 && yDir == 0)
		{
			xDir = 0;
			yDir = 1;
		}
		if (y < yMove && xDir == 0 && yDir == 1)
		{
			y = y + cameraVelocity;
			transform.position = transform.position + new Vector3(0, cameraVelocity * Time.deltaTime, 0); 
		}
		if (!(y < yMove) && xDir == 0 && yDir == 1)
		{
			xDir = -1;
			yDir = 0;
		}
		
        if (x > 0 && xDir == -1 && yDir == 0)
		{
			x = x - cameraVelocity;
			transform.position = transform.position + new Vector3(-cameraVelocity * Time.deltaTime, 0, 0); 
		}
		if (!(x > 0) && xDir == -1 && yDir == 0)
		{
			xDir = 0;
			yDir = -1;
		}
		if (y > 0 && xDir == 0 && yDir == -1)
		{
			y = y - cameraVelocity;
			transform.position = transform.position + new Vector3(0, -cameraVelocity * Time.deltaTime, 0); 
		}
		if (!(y > 0) && xDir == 0 && yDir == -1)
		{
			xDir = 1;
			yDir = 0;
		}
    }
}
