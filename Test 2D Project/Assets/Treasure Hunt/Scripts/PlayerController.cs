using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    float speed = 8;
    public Rigidbody2D rb;
    public AudioSource walking;

    bool isWalking;
    int walkingCounter = 0;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (walkingCounter == 0)
        {
            StartCoroutine(walkSound());
            walkingCounter++;
        }
    }

    IEnumerator walkSound()
    {
        float xInput = Input.GetAxis("Horizontal");
        float yInput = Input.GetAxis("Vertical");

        if (!isWalking && (Mathf.Abs(xInput) > 0.05f || Mathf.Abs(yInput) > 0.05f) && !walking.isPlaying && !isWalking)
        {
            walking.Play();
            isWalking = true;
            yield return new WaitForSeconds(0.5f);
            isWalking = false;
        }
        else if (Mathf.Abs(xInput) < 0.05f && Mathf.Abs(yInput) < 0.05f)
        {
            walking.Stop();
            isWalking = false;
        }

        walkingCounter--;
    }


    private void FixedUpdate()
    {
        float xInput = Input.GetAxis("Horizontal");
        float yInput = Input.GetAxis("Vertical");

        float newX = 0.0f;
        float newY = 0.0f;
        if (xInput > 0.05f || xInput < -0.05f)
            newX = xInput;

        if (yInput > 0.05f || yInput < -0.05f)
            newY = yInput;
        
        rb.velocity = new Vector2(newX * speed, newY * speed);
    }
}
