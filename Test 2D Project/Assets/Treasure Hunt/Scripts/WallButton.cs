using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallButton : MonoBehaviour
{
    public GameObject wall;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.name == "Player")
        {
            wall.GetComponent<BoxCollider2D>().enabled = false;
            wall.GetComponent<SpriteRenderer>().enabled = false;
        }
    }
}
