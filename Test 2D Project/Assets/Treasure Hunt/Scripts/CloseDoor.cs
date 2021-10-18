using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloseDoor : MonoBehaviour
{
    public GameObject door;

    private void OnTriggerExit2D(Collider2D collision)
    {
        door.GetComponent<SpriteRenderer>().enabled = true;
        door.GetComponent<BoxCollider2D>().enabled = true;
    }
}
