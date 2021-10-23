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
        collider = GetComponent<Collider2D>();
    }

    public override void ButtonPressed(GameObject box)
    {
        if (!boxes.Contains(box))
        {
            boxes.Add(box);

            // All the buttons are pressed, so we can open the door
            if (boxes.Count >= buttonNum)
            {
                sprite.enabled = false;
                collider.enabled = false;
            }
        }
    }

    public override void ButtonUnpressed(GameObject box)
    {
        boxes.Remove(box);

        if (boxes.Count < buttonNum)
        {
            // Close the door
            sprite.enabled = true;
            collider.enabled = true;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
