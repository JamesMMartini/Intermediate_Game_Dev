using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorMechanism : ButtonObject
{
    public int buttonNum;

    List<GameObject> boxes;

    private void Awake()
    {
        boxes = new List<GameObject>();

        sprite = GetComponent<SpriteRenderer>();
        newCollider2D = GetComponent<Collider2D>();
    }

    public override void ButtonPressed(GameObject box)
    {
        if (!boxes.Contains(box))
        {
            boxes.Add(box);

            float doorOpacity = (float)boxes.Count / (float)buttonNum;

            if (doorOpacity > 1)
                doorOpacity = 1f;

            sprite.color = new Color(sprite.color.r, sprite.color.g, sprite.color.b, 1 - doorOpacity);

            // All the buttons are pressed, so we can open the door
            if (doorOpacity == 1f)
            {
                newCollider2D.enabled = false;
            }
        }
    }

    public override void ButtonUnpressed(GameObject box)
    {
        boxes.Remove(box);

        float doorOpacity = (float)boxes.Count / (float)buttonNum;

        if (doorOpacity > 1)
            doorOpacity = 1f;

        sprite.color = new Color(sprite.color.r, sprite.color.g, sprite.color.b, 1 - doorOpacity);

        if (doorOpacity < 1f)
        {
            // Close the door
            newCollider2D.enabled = true;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
