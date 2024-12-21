using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Rigidbody2D rb;

    [SerializeField] private float speed;
    [SerializeField] private float jumpForce;

    private Vector2 moveVector;

    private bool isGround = false;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        InputController();

        if (Input.GetKeyDown(KeyCode.Space))
        {
            Jump();
        }
    }

    private void FixedUpdate()
    {
        Movement();
    }

    private void InputController()
    {
        moveVector.x = Input.GetAxis("Horizontal") * speed;
    }

    private void Movement()
    {
        rb.velocity = new Vector2(moveVector.x, rb.velocity.y);
    }

    private void Jump()
    {
        if (isGround)
        {
            rb.velocity = new Vector2(rb.velocity.x, jumpForce);
            isGround = false;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            isGround = true;
        }
    }
}
