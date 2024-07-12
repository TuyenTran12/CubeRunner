using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class obstacle : MonoBehaviour
{
    public float moveSpeed;
    GameController m_controller;
    // Start is called before the first frame update
    void Start()
    {
        m_controller = FindObjectOfType<GameController>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += Vector3.left * moveSpeed * Time.deltaTime;
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("SceneLimit"))
        {
            Destroy(gameObject);
        }
    }
}
