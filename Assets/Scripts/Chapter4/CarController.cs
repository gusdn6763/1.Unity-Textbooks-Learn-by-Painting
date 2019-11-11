using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarController : MonoBehaviour
{
    private AudioSource audio;
    float speed = 0;
    Vector2 startPos;
    Vector2 endPos;

    private void Awake()
    {
        audio = GetComponent<AudioSource>();
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
            startPos = Input.mousePosition;

        if (Input.GetMouseButtonUp(0))
        {
            endPos = Input.mousePosition;
            float swipeLength = endPos.x - startPos.x;

            this.speed = swipeLength / 500.0f;

            if (!audio.isPlaying)
            {
                audio.Play();
            }

            else
            {
                audio.Stop();
                audio.Play();
            }
        }

        transform.Translate(this.speed, 0, 0);
        this.speed *= 0.98f;
    }
}