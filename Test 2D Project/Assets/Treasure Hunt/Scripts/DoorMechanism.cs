using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorMechanism : ButtonObject
{
    bool[] buttonsPressed;
    public int buttonNum;

    List<GameObject> boxes;

    private void Awake()
    {
        buttonsPressed = new bool[buttonNum];
        boxes = new List<GameObject>();

        sprite = GetComponent<SpriteRenderer>();
        collider = GetComponent<Collider2D>();
    }

    public override void ButtonPressed(GameObject box)
    {
        if (!boxes.Contains(box))
        {
            // Find on open button to press
            for (int i = 0; i < buttonsPressed.Length; i++)
            {
                if (!buttonsPressed[i])
                {
                    buttonsPressed[i] = true;
                    i = buttonsPressed.Length;
                }
            }

            // Count the number of pressed buttons
            int pressedCount = 0;
            foreach (bool pressed in buttonsPressed)
                if (pressed)
                    pressedCount++;

            // All the buttons are pressed, so we can open the door
            if (pressedCount == buttonNum)
            {
                sprite.enabled = false;
                collider.enabled = false;
            }

            boxes.Add(box);
        }
    }

    public override void ButtonUnpressed(GameObject box)
    {
        // Find a button to unpress
        for (int i = 0; i < buttonsPressed.Length; i++)
        {
            if (buttonsPressed[i])
            {
                buttonsPressed[i] = false;
                i = buttonsPressed.Length;
            }
        }

        boxes.Remove(box);

        // Close the door
        sprite.enabled = true;
        collider.enabled = true;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
