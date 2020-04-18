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
    private bool startTimer = false;
    float time_since_timer_started;

    // Start is called before the first frame update
    //void Start()
    //{
    //    startTime = Time.time;

    //}

    void Start() {
        //startTimer = true;
        //startTime = Time.time;
        time_since_timer_started = 0;
    }

    // Update is called once per frame
    void Update()
    {

        time_since_timer_started += Time.deltaTime;

        if(stopTimer)
        {
            return;
        }


        if (gameObject.activeSelf == true) {

            string minutes = ((int)time_since_timer_started / 60).ToString();
            string seconds = (time_since_timer_started % 60).ToString("f2");
            timerText.text = minutes + ":" + seconds;
        }

        if (gameObject.activeSelf == false) {
            time_since_timer_started = 0;
        }
    }

    public void StopTimer()
    {
        stoppedTime = timerText;
        startTimer = false;
    }
}
