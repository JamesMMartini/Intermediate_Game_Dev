using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraCheckOne : MonoBehaviour
{
    BoxCollider2D boxCollider;
    public GameObject cameraController;

    // Start is called before the first frame update
    void Start()
    {
        boxCollider = GetComponent<BoxCollider2D>();
        boxCollider.isTrigger = true;
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.name == "BallOne")
        {
            CameraController controller = cameraController.GetComponent<CameraController>();
            controller.camera.transform.position = controller.cameraPositions[1];
        }

    }
}
