using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PlayerScript : MonoBehaviour
{
    [HideInInspector] public bool detected = false;
    Rigidbody2D body;
    SpriteRenderer spriteRenderer;
    public float speed = 5;
    GameObject gameOverPanel;

    void Start()
    {
        body = GetComponent<Rigidbody2D>();
        spriteRenderer = GetComponent<SpriteRenderer>();
        gameOverPanel = GameObject.Find("GameOverPanel");
        gameOverPanel.SetActive(false);
    }
    void Update()
    {
        body.velocity = new Vector3(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical")).normalized * speed;
        Vector3 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        spriteRenderer.flipX = transform.position.x > mousePosition.x;
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Camera"))
            detected = true;
        if(detected)
            gameOverPanel.SetActive(true);
        else
            gameOverPanel.SetActive(false);

    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Camera"))
            detected = false;
    }

    

}
