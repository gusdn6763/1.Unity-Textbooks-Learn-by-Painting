using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; // UI를 사용하므로 잊지 말고 추가

public class GameDirector5 : MonoBehaviour
{
    public GameObject hpGauge;
    public GameObject player;

    public void DecreaseHp()
    {
        hpGauge.GetComponent<Image>().fillAmount -= 0.1f;

        if (hpGauge.GetComponent<Image>().fillAmount == 0f)
        {
            Destroy(player);
        }
    }
}