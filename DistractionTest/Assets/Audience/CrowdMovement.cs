using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrowdMovement : MonoBehaviour
{
    static Animator anim;
    private Rigidbody rb;
    public float speed = 10F;
    private int WalkDirection;
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
        rb = GetComponent<Rigidbody>();
        //ChooseDirection();
    }

    // Update is called once per frame
    void Update()
    {
        gameObject.transform.position += new Vector3(0, 0, Time.deltaTime * speed);
    }

    /**public void ChooseDirection()
    {
        WalkDirection = Random.Range(0, 4);
    }
    */
    private void OnTriggerEnter(Collider other)
    {
        gameObject.transform.rotation = new Quaternion(0, 90, 0, 0);
        gameObject.transform.position += new Vector3(0, 0, -(Time.deltaTime * speed));
    }


}
