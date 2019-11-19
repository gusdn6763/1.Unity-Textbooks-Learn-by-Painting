using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RouletteController : MonoBehaviour
{
    Collider2D checkObject;
    float rotSpeed = 0;  // 회전속도
    Vector2 tapPoint;

    private void Awake()
    {
        checkObject = GetComponent<Collider2D>();
    }

    void Update()
    {
        //클릭시        Input.GetMouseButtonDown(0)
        //클릭 중       Input.GetMouseButton(0);
        //클릭 뛴 후    Input.GetMouseButtonUp(0);

        if (Input.GetMouseButtonDown(0))
        {
            tapPoint = Camera.main.ScreenToWorldPoint(Input.mousePosition);

            if(checkObject.OverlapPoint(tapPoint) == true)
            {
                this.rotSpeed = Random.Range(40, 50);
            }

        }         
        transform.Rotate(0, 0, this.rotSpeed);

        this.rotSpeed *= Random.Range(0.93f, 0.96f);
    }
}
