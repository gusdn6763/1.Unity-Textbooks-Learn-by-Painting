using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarController : MonoBehaviour
{

    float speed = 0;
    Vector2 startPos;

    void Update()
    {
        if (Input.GetMouseButtonDown(0))  startPos = Input.mousePosition;

        if (Input.GetMouseButtonUp(0))
        {
            Vector2 endPos = Input.mousePosition;
            float swipeLength = endPos.x - this.startPos.x;
            speed = swipeLength / 500.0f;
        }

        transform.Translate(speed, 0, 0);
        speed *= 0.98f;
    }
}