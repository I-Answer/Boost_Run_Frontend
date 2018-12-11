﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameOver_UI : MonoBehaviour {

    private List<string> eventString;

    public Text maxSpeedText, endureTimeText, eventText;

    private void Awake() {
        eventString = new List<string>();

        eventString.Add("");
        eventString.Add("최고 속도 달성!!");
        eventString.Add("최고 시간 달성!!");
        eventString.Add("최고 속도, 시간 달성!!");

        gameObject.SetActive(false);
    }

    public void Active(int maxSpeed, int endureTime, byte maxEvent) {
        maxSpeedText.text = string.Format("{0} km/h", maxSpeed);
        endureTimeText.text = string.Format("{0} : {1}", endureTime / 60, endureTime % 60);

        eventText.text = eventString[maxEvent];

        gameObject.SetActive(true);
    }

    public void LoadHome() {
        // TODO: 서버에 점수 보내는 행동

        Time.timeScale = 1f;
        SceneManager.SceneLoad("HomeScene");
    }
}