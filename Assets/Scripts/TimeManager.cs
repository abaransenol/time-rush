using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class TimeManager : MonoBehaviour
{
    public PlayerLiveController playerLiveController;

    public float time = 1f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (time <= 0) {
            playerLiveController.PlayerDied();
        }

        time -= Time.deltaTime;
        GameObject.Find("TimeText").GetComponent<Text>().text = "Seconds: " + Math.Round(time, 2);
    }
}
