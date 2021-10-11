using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{
    public BoxCollider2D col;
    public SpriteRenderer sprite;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.name == "Player")
        {
            sprite.enabled = false;
            col.enabled = false;
        }
    }
}
