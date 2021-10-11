using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PegglePeg : MonoBehaviour
{
    public Color newColor = Color.white;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        StartCoroutine(PegHitRoutine());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator PegHitRoutine()
    {
        GetComponent<Collider2D>().enabled = false;
        GetComponent<SpriteRenderer>().color = newColor;

        yield return new WaitForSeconds(0.75f);

        GetComponent<SpriteRenderer>().enabled = false;
    }
}
