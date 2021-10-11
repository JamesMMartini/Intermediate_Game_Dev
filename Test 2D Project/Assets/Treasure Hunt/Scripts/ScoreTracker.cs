using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ScoreTracker : MonoBehaviour
{
    public int score;

    public TMP_Text scoreDisplay;

    public GameObject friend;

    public TMP_Text questText;

    bool displayedMessage = false;

    // Start is called before the first frame update
    void Start()
    {
        friend.GetComponent<BoxCollider2D>().enabled = false;
        friend.GetComponent<SpriteRenderer>().enabled = false;

        questText.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        scoreDisplay.text = score.ToString();

        if (score == 1000 && !displayedMessage)
        {
            friend.GetComponent<BoxCollider2D>().enabled = true;
            friend.GetComponent<SpriteRenderer>().enabled = true;

            StartCoroutine(DisplayFinalQuest());
            displayedMessage = true;
        }
    }

    private IEnumerator DisplayFinalQuest()
    {
        questText.text = "Return to the home for a message from your friend";
        questText.enabled = true;

        yield return new WaitForSeconds(3f);

        questText.enabled = false;
    }
}
