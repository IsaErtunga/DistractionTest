using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class video1Trigg : MonoBehaviour
{
    public GameObject vp;

    void Start()
    {
        vp.SetActive(false);
    }
    // Start is called before the first frame update
    private void OnTriggerEnter(Collider player)
    {
        vp.SetActive(true);
    }
    private void OnTriggerExit(Collider player)
    {
        vp.SetActive(false);
    }
}
