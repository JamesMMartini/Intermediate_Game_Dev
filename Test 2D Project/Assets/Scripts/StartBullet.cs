using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartBullet : MonoBehaviour
{
    public Rigidbody2D rb;
    public float power;

    bool move = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            move = true;
            rb.AddForce(Vector2.right * power);
        }

        //if (move == true)
        //{
        //    rb.AddForce()
        //}
    }
}
