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
        timer.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter (Collider other) {
        ob.SetActive(true);
        timer.SetActive(true);
    }

    private void OnTriggerExit (Collider other) {
        ob.SetActive(false);
        timer.SetActive(false);
    }

}
