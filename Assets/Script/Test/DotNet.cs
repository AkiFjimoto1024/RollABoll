using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DotNet : MonoBehaviour
{
    // Start is called before the first frame update
    public Text DayText;
    public Text DayAppWeekText;
    void Start()
    {
        ShowTime();

        DayText.text = DateTime.Now.ToString();
        DayAppWeekText.text = DateTime.Now.AddDays(7).ToString();
    }

    void ShowTime()
    {
        DateTime now = DateTime.Now; // 今の時間を取得する
        Debug.Log(now); // 今の時間をゲームに表示する
    }
}
