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
        DateTime now = DateTime.Now; // ���̎��Ԃ��擾����
        Debug.Log(now); // ���̎��Ԃ��Q�[���ɕ\������
    }
}
