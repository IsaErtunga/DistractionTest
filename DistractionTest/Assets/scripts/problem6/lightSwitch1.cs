using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lightSwitch1 : MonoBehaviour
{
    public Light spot;

    // Update is called once per frame
    void Update()
    {
        if (DoorScript1.doorLocked == false)
        {
            spot.color = Color.green;
            return;
        }
        
    }
}
