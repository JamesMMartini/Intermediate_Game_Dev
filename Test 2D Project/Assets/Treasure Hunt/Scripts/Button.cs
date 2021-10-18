using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Button : MonoBehaviour
{
    public ButtonObject buttonObject;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Holdable"))
        {
            buttonObject.ButtonPressed(collision.gameObject);
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Holdable"))
        {
            buttonObject.ButtonUnpressed(collision.gameObject);
        }
    }
}
