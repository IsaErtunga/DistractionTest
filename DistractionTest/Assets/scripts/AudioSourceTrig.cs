using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioSourceTrig : MonoBehaviour
{
    public GameObject AudioSourceTrigger1;
    public GameObject AudioSourceTrigger2;

    // Start is called before the first frame update
    void Start()
    {
        AudioSourceTrigger1.SetActive(false);
        AudioSourceTrigger2.SetActive(false);
    }

    // Update is called once per frame
    private void OnTriggerEnter (Collider other) {
        AudioSourceTrigger1.SetActive(true);
        AudioSourceTrigger2.SetActive(true);
    }

    private void OnTriggerExit (Collider other) {
        AudioSourceTrigger1.SetActive(false);
        AudioSourceTrigger2.SetActive(false);
    }
}
