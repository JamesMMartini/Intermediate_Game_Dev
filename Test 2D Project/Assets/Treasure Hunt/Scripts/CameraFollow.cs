using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public GameObject player;
    float yBuffer = 1f;
    float xBuffer = 3f;

    public float leftBoundary = -48f;
    public float rightBoundary = 21f;
    public float topBoundary = 26f;
    public float bottomBoundary = -26f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float playerX = player.transform.position.x;
        float playerY = player.transform.position.y;

        float cameraX = transform.position.x;
        float cameraY = transform.position.y;

        // Move the camera to fit the player if they left the dead zone
        float newX = cameraX;
        float newY = cameraY;
        if (playerX < cameraX - xBuffer)
            newX = playerX + xBuffer;
        else if (playerX > cameraX + xBuffer)
            newX = playerX - xBuffer;

        if (playerY < cameraY - yBuffer)
            newY = playerY + yBuffer;
        else if (playerY > cameraY + yBuffer)
            newY = playerY - yBuffer;

        // Make sure the camera doesn't leave the world boundaries
        if (newX < leftBoundary)
            newX = leftBoundary;
        else if (newX > rightBoundary)
            newX = rightBoundary;

        if (newY < bottomBoundary)
            newY = bottomBoundary;
        else if (newY > topBoundary)
            newY = topBoundary;

        transform.position = new Vector3(newX, newY, -10f);
    }
}
