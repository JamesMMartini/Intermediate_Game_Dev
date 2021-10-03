using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public Camera camera;
    public Vector3[] cameraPositions = new Vector3[5];

    bool follow = false;

    public GameObject ballTwo;

    // Start is called before the first frame update
    void Start()
    {
        camera.transform.position = cameraPositions[0];
    }

    // Update is called once per frame
    void Update()
    {
        if (camera.transform.position == cameraPositions[3])
        {
            follow = true;
        }

        if (follow)
        {
            Vector3 newVect = new Vector3();
            if (ballTwo.transform.position.x >= 25)
                newVect.x = 25;
            else
                newVect.x = ballTwo.transform.position.x;

            if (ballTwo.transform.position.y >= 0)
                newVect.y = 0;
            else if (ballTwo.transform.position.y <= -11.5f)
                newVect.y = -11.5f;
            else
                newVect.y = ballTwo.transform.position.y;

            newVect.z = -10f;

            camera.transform.position = newVect;
        }
    }
}
