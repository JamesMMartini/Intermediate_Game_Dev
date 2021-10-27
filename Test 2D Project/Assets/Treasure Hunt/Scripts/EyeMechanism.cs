using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EyeMechanism : MonoBehaviour
{
    public float raycastDistance = 6.0f;

    public GameObject door;
    public Color goColor;
    public Color noColor;

    bool closed = false;
    int coolDown = 0;

    private void Start()
    {
        GetComponent<SpriteRenderer>().color = goColor;
    }

    // Update is called once per frame
    void Update()
    {
        if (!closed)
        {
            StartCoroutine(CheckDoorway());
        }
    }

    IEnumerator CheckDoorway()
    {
        RaycastHit2D ray = Physics2D.Raycast(transform.position, Vector2.down, raycastDistance);

        if (ray.collider != null && ray.collider.CompareTag("Player"))
        {
            door.GetComponent<BoxCollider2D>().enabled = true;
            door.GetComponent<SpriteRenderer>().enabled = true;
            GetComponent<SpriteRenderer>().color = noColor;

            closed = true;

            yield return new WaitForSeconds(3.0f);

            closed = false;
            door.GetComponent<BoxCollider2D>().enabled = false;
            door.GetComponent<SpriteRenderer>().enabled = false;
            GetComponent<SpriteRenderer>().color = goColor;
        }
    }

    private void OnDrawGizmos()
    {
        Debug.DrawRay(transform.position, Vector2.down * raycastDistance, Color.yellow);
    }
}
