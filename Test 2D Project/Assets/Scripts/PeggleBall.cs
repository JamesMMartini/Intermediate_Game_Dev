using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PeggleBall : MonoBehaviour
{
    private Rigidbody2D rb;
    public float force = 1.0f;

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.simulated = false;
    }

    void MouseControls()
    {
        if (Input.GetMouseButton(0))
        {
            rb.simulated = true;
            transform.parent = null;
        }
    }

    // Update is called once per frame
    void Update()
    {
        MouseControls();
    }
}
