using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;

public class ClearTimeText : MonoBehaviour
{
    [SerializeField] Text clearTimeText;
    private float clearTime;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        clearTime = LastStageDoor.ClearTime;
    }

    // Update is called once per frame
    void Update()
    {

        int minutes = Mathf.FloorToInt(clearTime / 60);
        int seconds = Mathf.FloorToInt(clearTime % 60);
        clearTimeText.text = string.Format("Clear Time: {0:00}:{1:00}", minutes, seconds);
    }
}
