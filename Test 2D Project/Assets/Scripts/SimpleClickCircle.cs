using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimpleClickCircle : MonoBehaviour
{
    SpriteRenderer spriteRenderer;

    public Color colorOne = Color.red;
    public Color colorTwo = Color.green;

    private void Awake()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        spriteRenderer.color = colorOne;
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ChangeColor(int n)
    {
        //if (spriteRenderer.color == colorOne)
        //    spriteRenderer.color = colorTwo;
        //else
        //    spriteRenderer.color = colorOne;

        if (n == 0)
        {
            spriteRenderer.color = colorOne;
        }
        else if (n == 1)
        {
            spriteRenderer.color = colorTwo;
        }
    }
}
