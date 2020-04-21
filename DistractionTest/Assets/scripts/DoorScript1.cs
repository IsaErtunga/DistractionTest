using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorScript1 : MonoBehaviour
{
    Animator anim;
    public static bool doorLocked = true;
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
        doorLocked = true;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider other)
    {
        if (!doorLocked)
        {
            anim.SetTrigger("opentrigger");
        }
        
    }

    void OnTriggerExit(Collider other)
    {
        anim.enabled = true;
    }

   void pauseAnimationEvent()
    {
        anim.enabled = false;
    }

}
