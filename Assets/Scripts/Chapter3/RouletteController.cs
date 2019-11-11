using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RouletteController : MonoBehaviour
{
    Collider2D collCheck;
    Vector2 tapPoint;
    float rotSpeed;

    private void Awake()
    {
        collCheck = GetComponent<Collider2D>();
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            tapPoint = Camera.main.ScreenToWorldPoint(Input.mousePosition);

            if (collCheck.OverlapPoint(tapPoint))
                rotSpeed = Random.Range(40f, 50f);
        }

        transform.Rotate(0, 0, this.rotSpeed);

        this.rotSpeed *= Random.Range(0.94f, 0.96f);
    }
}
