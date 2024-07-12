using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float jumpForce = 400;

    Rigidbody2D m_rb;

    bool m_isGrounded;
    GameController m_controller;
    AudioManager m_audioManager;
    
    // Start is called before the first frame update
    void Start()
    {
        m_rb = GetComponent<Rigidbody2D>();
        m_controller = FindObjectOfType<GameController>();
        m_audioManager = FindAnyObjectByType<AudioManager>();
    }

    // Update is called once per frame
    void Update()
    {
        bool isJumpKeyPress = Input.GetKeyDown(KeyCode.Space);
        if (isJumpKeyPress && m_isGrounded)
        {
            //vecter.up = (0,1)
            m_rb.AddForce(Vector2.up * jumpForce);
            m_isGrounded = false;
            m_audioManager.PlaySFX(m_audioManager.JumpClip);
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.CompareTag("Ground"))
        {
            m_isGrounded = true;
        }    
        if(collision.gameObject.CompareTag("Obstacle"))
        {
            m_controller.EndGame();
            m_audioManager.PlaySFX(m_audioManager.LoseClip);
        }    
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.CompareTag("Point"))
        {
            m_controller.countPoint();
        }    
    }
}
