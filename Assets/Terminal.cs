using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Experimental.Rendering.Universal;


public class Terminal : MonoBehaviour
{
    AudioSource AudioSource;
    BoxCollider2D BoxCollider2D;
    Light2D Light2D;
    public static int activeTerminals;
    bool active;
    public GameObject tube;
    public GameObject finale;
    public AudioClip activate;
    // Start is called before the first frame update
    void Start()
    {
        Light2D = GetComponent<Light2D>();
        AudioSource = GetComponent<AudioSource>();
        BoxCollider2D = GetComponent<BoxCollider2D>();
    }

    // Update is called once per frame
    private void OnCollisionEnter2D(Collision2D collision)
    {
        {
            if (collision.gameObject.CompareTag("Player") && !active)
            {
                active = true;
                activeTerminals++;
                AudioSource.PlayOneShot(activate);
                tube.GetComponent<Light2D>().enabled = true;
                Light2D.color = Color.green;
                if (activeTerminals > 3)
                {
                    finale.GetComponent<finaleScript>().activated = true;
                    finale.GetComponent<Light2D>().color = Color.green;
                }
                    
            }
        }
    }
}
