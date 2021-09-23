using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move_Camera : MonoBehaviour
{
    public GameObject guy;

    public GameObject leftEnd;
    public GameObject rightEnd;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (guy.transform.position.x > transform.position.x + 4.5f && transform.position.x + 7.5f < rightEnd.transform.position.x)
        {
            Vector3 newPos = transform.position;
            newPos.x = guy.transform.position.x - 4.5f;
            transform.position = newPos;
        } else if (guy.transform.position.x < transform.position.x - 4.5f && transform.position.x - 7.5f > leftEnd.transform.position.x)
        {
            Vector3 newPos = transform.position;
            newPos.x = guy.transform.position.x + 4.5f;
            transform.position = newPos;
        }
    }
}
