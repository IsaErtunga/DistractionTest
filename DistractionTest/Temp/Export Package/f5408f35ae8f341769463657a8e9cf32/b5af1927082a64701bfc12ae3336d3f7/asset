using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirstRoomScript : MonoBehaviour
{

    public GameObject ob;
    public GameObject timer;
    // Start is called before the first frame update
    void Start()
    {
        ob.SetActive(false);
    }

    private void OnTriggerEnter (Collider other) {
        ob.SetActive(true);
        TimerScript.startTimer();
    }

    private void OnTriggerExit (Collider other) {
        ob.SetActive(false);
    }
}
