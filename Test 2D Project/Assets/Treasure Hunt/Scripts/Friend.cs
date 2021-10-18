using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Friend : MonoBehaviour
{
    public TMP_Text questText;
    public GameObject finalDoor;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.name == "Player")
        {
            finalDoor.GetComponent<SpriteRenderer>().enabled = false;
            finalDoor.GetComponent<BoxCollider2D>().enabled = false;

            StartCoroutine(DisplayEnd());
        }
    }

    private IEnumerator DisplayEnd()
    {
        questText.text = "Find the new passage in the Northeast to keep going!";
        questText.enabled = true;

        yield return new WaitForSeconds(3f);

        questText.enabled = false;
    }
}
