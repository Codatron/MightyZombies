using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PlayerScript : MonoBehaviour
{
    [HideInInspector] public bool detected = false;
    Rigidbody2D body;
    public float speed = 5;

    public GameObject gameOverPanel;

    void Start()
    {
        body = GetComponent<Rigidbody2D>();
        gameOverPanel.SetActive(false);
    }
    void Update()
    {
        body.velocity = new Vector3(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical")).normalized * speed;
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Camera"))
            detected = true;
  
            gameOverPanel.SetActive(true);
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Camera"))
            detected = false;
    }
}
