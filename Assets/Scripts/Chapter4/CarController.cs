using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarController : MonoBehaviour
{
    private AudioSource CarAudio;
    float speed = 0;
    Vector2 startPos;
    Vector2 endPos;

    private void Awake()
    {
        CarAudio = GetComponent<AudioSource>();
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

            if (!CarAudio.isPlaying)
            {
                CarAudio.Play();
            }

            else
            {
                CarAudio.Stop();
                CarAudio.Play();
            }
        }

        transform.Translate(this.speed, 0, 0);
        this.speed *= 0.98f;
    }
}