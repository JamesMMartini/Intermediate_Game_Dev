using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RBMovement : MonoBehaviour
{
    Rigidbody2D rb;
    
    float jumpStrength = 5f;
    float movementSpeed = 5f;

    float moveX;
    bool onGround, canJump;

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void PlayerControls()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            canJump = true;
        }

        moveX = Input.GetAxis("Horizontal") * movementSpeed;
    }

    void Jump()
    {
        if (!onGround)
            return;

        onGround = false;

        rb.AddForce(Vector2.up * jumpStrength, ForceMode2D.Impulse);
    }

    private void FixedUpdate()
    {
        rb.velocity = new Vector2(moveX, rb.velocity.y);

        if (canJump)
        {
            canJump = false;
            Jump();
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name == "Floor")
            onGround = true;
    }

    // Update is called once per frame
    void Update()
    {
        PlayerControls();
    }
}
