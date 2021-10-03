using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Guy_Controller : MonoBehaviour
{
    public Sprite[] sprites;
    public GameObject sprite;

    public GameObject leftEnd;
    public GameObject rightEnd;

    int spriteFrame;
    int spriteIncrement;

    int speed = 4;

    // Start is called before the first frame update
    void Start()
    {
        sprite.GetComponent<SpriteRenderer>().sprite = sprites[0];
    }

    public void MoveLeft()
    {
        if (transform.localScale.x != -1)
        {
            Vector3 theScale = transform.localScale;
            theScale.x *= -1;
            transform.localScale = theScale;
        }

        if (spriteIncrement >= 12)
        {
            switch (spriteFrame)
            {
                case 0:
                    spriteFrame = 1;
                    sprite.GetComponent<SpriteRenderer>().sprite = sprites[1];
                    break;
                case 1:
                    spriteFrame = 2;
                    sprite.GetComponent<SpriteRenderer>().sprite = sprites[2];
                    break;
                case 2:
                    spriteFrame = 3;
                    sprite.GetComponent<SpriteRenderer>().sprite = sprites[3];
                    break;
                case 3:
                    spriteFrame = 1;
                    sprite.GetComponent<SpriteRenderer>().sprite = sprites[1];
                    break;
            }
            spriteIncrement = 0;
        }
        else
        {
            spriteIncrement++;
        }

        transform.Translate(Vector2.left * Time.deltaTime * 4);
    }

    public void MoveRight()
    {
        if (transform.localScale.x != 1)
        {
            Vector3 theScale = transform.localScale;
            theScale.x *= -1;
            transform.localScale = theScale;
        }

        if (spriteIncrement >= 12)
        {
            switch (spriteFrame)
            {
                case 0:
                    spriteFrame = 1;
                    sprite.GetComponent<SpriteRenderer>().sprite = sprites[1];
                    break;
                case 1:
                    spriteFrame = 2;
                    sprite.GetComponent<SpriteRenderer>().sprite = sprites[2];
                    break;
                case 2:
                    spriteFrame = 3;
                    sprite.GetComponent<SpriteRenderer>().sprite = sprites[3];
                    break;
                case 3:
                    spriteFrame = 1;
                    sprite.GetComponent<SpriteRenderer>().sprite = sprites[1];
                    break;
            }
            spriteIncrement = 0;
        }
        else
        {
            spriteIncrement++;
        }

        transform.Translate(Vector2.right * Time.deltaTime * 4);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.D) && transform.position.x <= rightEnd.transform.position.x)
        {
            MoveRight();
        }
        else if (Input.GetKey(KeyCode.A) && transform.position.x >= leftEnd.transform.position.x)
        {
            MoveLeft();
        }
        else
        {
            spriteFrame = 0;
            sprite.GetComponent<SpriteRenderer>().sprite = sprites[0];
        }
    }
}
