using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HexLauncher : MonoBehaviour
{
    BoxCollider2D boxCollider;
    public GameObject hex;

    public float power;

    // Start is called before the first frame update
    void Start()
    {
        boxCollider = GetComponent<BoxCollider2D>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("IN THE METHOD");
        if (collision.gameObject.name == "BallOne")
        {
            Rigidbody2D rb = hex.GetComponent<Rigidbody2D>();
            rb.AddForce(Vector2.up * power);
        }
    }
}
