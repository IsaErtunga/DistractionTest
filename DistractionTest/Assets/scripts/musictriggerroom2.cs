using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class musictriggerroom2 : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        FindObjectOfType<AudioManager>().Play("Room 2");
    }

    void OnTriggerExit(Collider other)
    {
        FindObjectOfType<AudioManager>().Stop("Room 2");
    }
}
