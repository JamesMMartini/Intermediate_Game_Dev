using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RockButton : MonoBehaviour
{
    public GameObject rock;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.name == "Player")
        {
            rock.GetComponent<CircleCollider2D>().enabled = false;
            rock.GetComponent<SpriteRenderer>().enabled = false;
        }
    }
}
