using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ComputerScript : MonoBehaviour
{
    
    bool onComp;
    List<LineRenderer> Lines = new List<LineRenderer>();
    CircleCollider2D Collider;
    List<CameraScript> linkedCameras = new List<CameraScript>();
    // Start is called before the first frame update
    void Start()
    {
        Collider = GetComponent<CircleCollider2D>();

        foreach (Transform child in transform)
        {
            
            Lines.Add(child.GetComponent <LineRenderer>());
            linkedCameras.Add(child.GetComponent<ConnectionScript>().Camera.GetComponent<CameraScript>());
        }
    }

    // Update is called once per frame
    void Update()
    {
        
        for (int i = 0; i<Lines.Count; i++)
        {
            if (onComp)
            {
                Lines[i].enabled = true;
                if (Input.GetKeyDown(KeyCode.Space))
                    linkedCameras[i].turnedOn = !linkedCameras[i].turnedOn;
            }
            else
                Lines[i].enabled = false;
        }
            

    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            onComp = true;
            Debug.Log(onComp);
        }
            
    }
    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            onComp = false;
            Debug.Log(onComp);
        }
            
    }
}
