using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;

public class PoisonTimerText : MonoBehaviour
{
    [SerializeField] Text timeText;
    [SerializeField] AvoidPoisonTimer avoidpoisonTimer;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        int minutes = Mathf.FloorToInt(avoidpoisonTimer.AvoidTime / 60);
        int seconds = Mathf.FloorToInt(avoidpoisonTimer.AvoidTime % 60);
        timeText.text = string.Format("{0:00}:{1:00}", minutes, seconds);
    }
}
