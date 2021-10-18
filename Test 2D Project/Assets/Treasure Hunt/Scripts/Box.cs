using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Box : MonoBehaviour
{
    bool attached = false;
    GameObject holding;

    int cooldown = 0;

    public TMP_Text gameInstructions;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (attached && transform.parent.transform.parent == null)
        {
            transform.parent.transform.parent = holding.transform;
        }
        else if (attached && transform.parent.transform.parent != null && Input.GetKeyDown(KeyCode.E))
        {
            Vector3 dir = holding.transform.position - transform.position;

            transform.parent.transform.parent = null;
            holding = null;
            attached = false;

            transform.parent.transform.position -= dir * Time.deltaTime * 25f;

            cooldown = 20;
        }

        if (cooldown > 0)
            cooldown--;
    }

    //private void OnCollisionEnter2D(Collision2D collision)
    //{
    //    if (collision.gameObject.name == "Player")
    //    {
    //        gameInstructions.text = "Press \"E\" to grab";
    //        gameInstructions.enabled = true;
    //    }
    //}

    //// If, at any point, the box is colliding with the player, check to make sure that it's
    //// the player and then see if the player has clicked the E key. Then attatch the box
    //// to the player.
    //private void OnCollisionStay2D(Collision2D collision)
    //{
    //    if (collision.gameObject.name == "Player" && Input.GetKey(KeyCode.E) && !attached && cooldown == 0)
    //    {
    //        holding = collision.gameObject;
    //        attached = true;
    //    }
    //}

    //private void OnCollisionExit2D(Collision2D collision)
    //{
    //    if (collision.gameObject.name == "Player")
    //    {
    //        gameInstructions.text = "";
    //        gameInstructions.enabled = false;
    //    }
    //}

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.name == "Player")
        {
            gameInstructions.text = "Press \"E\" to grab";
            gameInstructions.enabled = true;
        }
    }

    // If, at any point, the box is colliding with the player, check to make sure that it's
    // the player and then see if the player has clicked the E key. Then attatch the box
    // to the player.
    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.name == "Player" && Input.GetKey(KeyCode.E) && !attached && cooldown == 0)
        {
            holding = collision.gameObject;
            attached = true;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.name == "Player")
        {
            gameInstructions.text = "";
            gameInstructions.enabled = false;
        }
    }
}
