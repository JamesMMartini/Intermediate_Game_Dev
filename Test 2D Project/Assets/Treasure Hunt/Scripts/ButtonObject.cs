using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonObject : MonoBehaviour
{
    protected SpriteRenderer sprite;
    protected Collider2D collider;

    private void Awake()
    {
        sprite = GetComponent<SpriteRenderer>();
        collider = GetComponent<Collider2D>();
    }

    public virtual void ButtonPressed(GameObject box)
    {
        sprite.enabled = false;
        collider.enabled = false;
    }

    public virtual void ButtonUnpressed(GameObject box)
    {
        sprite.enabled = true;
        collider.enabled = true;
    }
}
