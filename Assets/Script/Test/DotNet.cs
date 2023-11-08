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
        DateTime now = DateTime.Now; // ¡‚ÌŠÔ‚ğæ“¾‚·‚é
        Debug.Log(now); // ¡‚ÌŠÔ‚ğƒQ[ƒ€‚É•\¦‚·‚é
    }
}
