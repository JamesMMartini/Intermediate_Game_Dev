using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collectible : MonoBehaviour
{
    public ScoreTracker tracker;
    public SpriteRenderer sprite;
    public CircleCollider2D col;
    public AudioSource sound;

    public Sprite[] sprites;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(Animate());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator Animate()
    {
        int counter = 0;

        while (true)
        {
            sprite.sprite = sprites[counter];
            yield return new WaitForSeconds(0.15f);
            counter++;

            if (counter > sprites.Length - 1)
                counter = 0;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.name == "Player")
        {
            tracker.score += 100;

            sound.Play();

            col.enabled = false;
            sprite.enabled = false;
        }
    }
}
