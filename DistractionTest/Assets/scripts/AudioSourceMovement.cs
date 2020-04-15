using UnityEngine;

public class AudioSourceMovement : MonoBehaviour
{

    //public Rigidbody rb;
    private float movementSpeed = 1.5f;
    Vector3 originalPos;

    void Start()
    {
        //rb.useGravity = false;
        originalPos = new Vector3(gameObject.transform.position.x, gameObject.transform.position.y, gameObject.transform.position.z);
    }

    // Update is called once per frame
    void Update()
    {
        //rb.AddForce(0, 0, 100 * Time.deltaTime);
        gameObject.transform.position = gameObject.transform.position + new Vector3(0, 0, movementSpeed * Time.deltaTime);


        if (gameObject.transform.position.z >= 57.0f) {
            gameObject.transform.position = originalPos;
        }
            
    }
}
