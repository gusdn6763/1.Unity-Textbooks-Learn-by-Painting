using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;  // UI 부품을 사용하기 위해서 중요!

public class GameDirector : MonoBehaviour
{

    public GameObject car;
    public GameObject flag;
    public Text distance;
    float length;

    void Update()
    {
        length = flag.transform.position.x - car.transform.position.x;
        if (length >= 0) distance.text = "도착 지점까지 " + length.ToString("F2") + "m";
        else distance.text = "끝";
    }
}