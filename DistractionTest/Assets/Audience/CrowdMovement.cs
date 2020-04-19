using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrowdMovement : MonoBehaviour
{
    static Animator anim;
    public Rigidbody rb;
    public float speed = 3F;
    private Vector3 myVector;
    private Collider target;

    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
        rb = GetComponent<Rigidbody>();
        target = GetComponent<Collider>();
        myVector = new Vector3(rb.velocity.x, rb.velocity.y, rb.velocity.z);
        if(rb.name == "NPCR1Forward")
        {
            rb.velocity = myVector + Vector3.forward * speed;

        }
        if (rb.name == "NPCR1Back")
        {
            rb.velocity = myVector + Vector3.back * speed;
        }
        if (rb.name == "NPCR2Left")
        {
            rb.velocity = myVector + Vector3.left * speed;
        }
        if (rb.name == "NPCR2Right")
        {
            rb.velocity = myVector + Vector3.right * speed;
        }

    }

    private void OnTriggerEnter(Collider other)
    {
        speed = speed * -1;
        if (rb.name == "NPCR1Forward")
        {
            gameObject.transform.Rotate(0, 180, 0, Space.Self);
            rb.velocity = Vector3.forward * speed;
        }
        if (rb.name == "NPCR1Back")
        {
            gameObject.transform.Rotate(0, rb.rotation.y - 180, 0, Space.Self);
            rb.velocity = Vector3.back * speed;
        }
        if (rb.name == "NPCR2Left")
        {
            gameObject.transform.Rotate(0, rb.rotation.y * 270, 0, Space.Self);
            rb.velocity = Vector3.left * speed;
        }
        if (rb.name == "NPCR2Right")
        {
            gameObject.transform.Rotate(0, rb.rotation.y * 270, 0, Space.Self);
            rb.velocity = Vector3.right * speed;
        }
    }


}
