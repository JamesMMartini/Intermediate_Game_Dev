using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collectible : MonoBehaviour
{
    public ScoreTracker tracker;
    public SpriteRenderer sprite;
    public CircleCollider2D col;
    public AudioSource sound;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
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
