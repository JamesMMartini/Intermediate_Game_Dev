using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PeggleBallShooter : MonoBehaviour
{
    public Rigidbody2D ballRB;

    Vector2 ballStartPosition;

    // Start is called before the first frame update
    void Start()
    {
        ballStartPosition = ballRB.transform.localPosition;
    }

    public void ResetBall()
    {
        ballRB.velocity = Vector2.zero;
        ballRB.angularVelocity = 0;
        ballRB.simulated = false;

        ballRB.transform.SetParent(transform, true);
        ballRB.transform.localPosition = ballStartPosition;
        ballRB.transform.localRotation = Quaternion.Euler(Vector3.zero);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
