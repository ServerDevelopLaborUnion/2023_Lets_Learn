using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    private Rigidbody2D rb2d = null;
    [SerializeField] float speed = 0f;
    private void Movement()
    {
        float X = Input.GetAxisRaw("Horizontal");
        rb2d.velocity = new Vector2(X * speed, rb2d.velocity.y);
    }
    void Awake()
    {
        rb2d = GetComponent<Rigidbody2D>();
    }
    void Start()
    {
        
    }
    void Update()
    {
        Movement();
    }
}