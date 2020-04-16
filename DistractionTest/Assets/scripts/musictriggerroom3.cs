using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class musictriggerroom3 : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        FindObjectOfType<AudioManager>().Play("Room 3");
    }

    void OnTriggerExit(Collider other)
    {
        FindObjectOfType<AudioManager>().Stop("Room 3");
    }
}
