using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimpleMouseClick : MonoBehaviour
{
    Camera mainCamera;

    private void Awake()
    {
        mainCamera = Camera.main;
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        ClickCheck();
    }

    void ClickCheck()
    {
        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit2D ray = Physics2D.GetRayIntersection(mainCamera.ScreenPointToRay(Input.mousePosition));

            if (ray.collider != null && ray.collider.CompareTag("ClickButton"))
            {
                ray.collider.gameObject.GetComponent<SimpleClickCircle>().ChangeColor(0);
            }
        }
        else if (Input.GetMouseButtonDown(1))
        {
            RaycastHit2D ray = Physics2D.GetRayIntersection(mainCamera.ScreenPointToRay(Input.mousePosition));

            if (ray.collider != null && ray.collider.CompareTag("ClickButton"))
            {
                ray.collider.gameObject.GetComponent<SimpleClickCircle>().ChangeColor(1);
            }
        }
    }
}
