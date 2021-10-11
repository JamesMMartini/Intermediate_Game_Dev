using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Friend : MonoBehaviour
{
    public TMP_Text questText;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.name == "Player")
        {
            StartCoroutine(DisplayEnd());
        }
    }

    private IEnumerator DisplayEnd()
    {
        questText.text = "Congratulations!";
        questText.enabled = true;

        yield return new WaitForSeconds(3f);

        questText.enabled = false;
    }
}
