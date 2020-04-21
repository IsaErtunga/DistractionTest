using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lightSwitch2 : MonoBehaviour
{
    public Light spot;

    // Update is called once per frame
    void Update()
    {
        if (DoorScript2.doorLocked == false)
        {
            spot.color = Color.green;
            return;
        }

    }
}

