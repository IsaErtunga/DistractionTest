using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorScript : MonoBehaviour
{
    Animator anim;
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider other)
    {
        anim.SetTrigger("opentrigger");
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
