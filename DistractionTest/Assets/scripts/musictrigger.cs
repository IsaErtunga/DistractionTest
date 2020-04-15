using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class musictrigger : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        FindObjectOfType<AudioManager>().Play("Room 1");
    }

    void OnTriggerExit(Collider other)
    {
        FindObjectOfType<AudioManager>().Stop("Room 1");
    }
}
