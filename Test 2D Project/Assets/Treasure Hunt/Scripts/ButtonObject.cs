using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonObject : MonoBehaviour
{
    protected SpriteRenderer sprite;
    protected Collider2D newCollider2D;

    private void Awake()
    {
        sprite = GetComponent<SpriteRenderer>();
        newCollider2D = GetComponent<Collider2D>();
    }

    public virtual void ButtonPressed(GameObject box)
    {
        sprite.enabled = false;
        newCollider2D.enabled = false;
    }

    public virtual void ButtonUnpressed(GameObject box)
    {
        sprite.enabled = true;
        newCollider2D.enabled = true;
    }
}
