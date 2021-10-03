using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move_Bird : MonoBehaviour
{
    public GameObject leftEnd;
    public GameObject rightEnd;

    public GameObject sprite;
    public Sprite[] sprites;

    int spriteFrame = 0;
    int spriteIncrement = 0;

    // Start is called before the first frame update
    void Start()
    {
        Vector3 theScale = transform.localScale;
        theScale.x = 1;
        transform.localScale = theScale;

        spriteFrame = 0;
        sprite.GetComponent<SpriteRenderer>().sprite = sprites[0];
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.localScale.x == 1 && transform.position.x >= leftEnd.transform.position.x - 7)
        {
            transform.Translate(Vector2.left * Time.deltaTime * 10);
        }
        else if (transform.localScale.x == 1 && transform.position.x < leftEnd.transform.position.x - 7)
        {
            Vector3 theScale = transform.localScale;
            theScale.x *= -1;
            transform.localScale = theScale;
        }
        else if (transform.localScale.x == -1 && transform.position.x < rightEnd.transform.position.x + 7)
        {
            transform.Translate(Vector2.right * Time.deltaTime * 10);
        }
        else
        {
            Vector3 theScale = transform.localScale;
            theScale.x *= -1;
            transform.localScale = theScale;
        }

        if (spriteIncrement >= 24)
        {
            if (spriteFrame == 0)
            {
                spriteFrame = 1;
                sprite.GetComponent<SpriteRenderer>().sprite = sprites[1];
            }
            else
            {
                spriteFrame = 0;
                sprite.GetComponent<SpriteRenderer>().sprite = sprites[0];
            }

            spriteIncrement = 0;
        }
        else
        {
            spriteIncrement++;
        }
    }
}
