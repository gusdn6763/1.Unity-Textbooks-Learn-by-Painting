using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{


    void Update()
    {
        // 왼쪽 화살표를 눌렀을 때
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            transform.Translate(-1, 0, 0);
        }

        // 오른쪽 화살표를 눌렀을 때
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            transform.Translate(1, 0, 0);
        }
    }

    public void LeftMove()
    {
        transform.Translate(-1, 0, 0);
    }

    public void RightMove()
    {
        transform.Translate(1, 0, 0);
    }
}