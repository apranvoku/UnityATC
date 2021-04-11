using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public Text timeText;
    public int minutes;
    public int hours;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(Time.realtimeSinceStartup);
        minutes = (int)(Time.realtimeSinceStartup * 5f);
        hours = minutes / 60;
        timeText.text = "Time: " + (hours%24).ToString() + "h " + (minutes%60).ToString() + "m";
    }
}
