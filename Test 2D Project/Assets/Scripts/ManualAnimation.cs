using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ManualAnimation : MonoBehaviour
{
    SpriteRenderer spriteRenderer;

    public List<Sprite> imageList = new List<Sprite>();
    public float delay = 0.1f;
    public float moveSpeed = 1f;

    public AnimationCurve animationCurve;

    private void Awake()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(Animate());
        StartCoroutine(Move());
        StartCoroutine(EvalCurve());
    }

    IEnumerator Animate()
    {
        int counter = 0;

        while (true)
        {
            spriteRenderer.sprite = imageList[counter];
            yield return new WaitForSeconds(delay);
            counter++;

            if (counter > imageList.Count - 1)
                counter = 0;
        }
    }

    IEnumerator Move()
    {
        while (true)
        {
            transform.position = new Vector3(transform.position.x - Time.deltaTime * moveSpeed, transform.position.y, transform.position.z);

            yield return null;

            if (transform.position.x < -9f)
            {
                transform.position = new Vector3(9f, transform.position.y, transform.position.z);
            }
        }
    }

    IEnumerator EvalCurve()
    {
        while (true)
        {
            float t = 0.0f;

            while (t < 1.0f)
            {
                t += Time.deltaTime;

                transform.position = new Vector3(animationCurve.Evaluate(t), 0.0f, 0.0f);

                yield return null;
            }
        }
    }
}