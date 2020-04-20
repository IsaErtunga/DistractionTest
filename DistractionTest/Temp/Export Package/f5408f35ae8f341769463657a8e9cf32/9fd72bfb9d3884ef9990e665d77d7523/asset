using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class TimerScript : MonoBehaviour
{
    public Text timerText;
    public Text stoppedTime;
    static float time_since_timer_started;
    static bool timerBool = false;

    public static void startTimer() {

        timerBool = true;
        time_since_timer_started = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (timerBool == true) {
            time_since_timer_started += Time.deltaTime;
            string minutes = ((int)time_since_timer_started / 60).ToString();
            string seconds = (time_since_timer_started % 60).ToString("f2");
            timerText.text = minutes + ":" + seconds;
        }
    }

    public static void StopTimer()
    {
        ProblemInput.addTime(time_since_timer_started);
        timerBool = false;
    }
}
