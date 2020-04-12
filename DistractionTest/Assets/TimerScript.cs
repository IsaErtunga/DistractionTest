using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class TimerScript : MonoBehaviour
{
    public Text timerText;
    public Text stoppedTime;
    private float startTime;
    private bool stopTimer = false;

    // Start is called before the first frame update
    void Start()
    {
        startTime = Time.time;

    }

    // Update is called once per frame
    void Update()
    {
        if(stopTimer)
        {
            return;
        }

        float time_since_timer_started = Time.time - startTime;
        string minutes = ((int)time_since_timer_started / 60).ToString();
        string seconds = (time_since_timer_started % 60).ToString("f2");
        timerText.text = minutes + ":" + seconds;
    }

    public void StopTimer()
    {
        stopTimer = true;
        stoppedTime = timerText;
    }
}
