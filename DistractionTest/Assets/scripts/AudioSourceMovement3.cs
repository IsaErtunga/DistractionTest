using UnityEngine;

public class AudioSourceMovement3 : MonoBehaviour
{
    private float movementSpeed = 3.5f;
    Vector3 originalPos1;
    Vector3 originalPos2;
    private bool forward = true;

    void Start()
    {
        originalPos1 = new Vector3(gameObject.transform.position.x, gameObject.transform.position.y, gameObject.transform.position.z);
        originalPos2 = new Vector3(56.0f, 40.0f, 100.0f);
    }

    // Update is called once per frame
    void Update()
    {
        if (forward == true) {
            gameObject.transform.position = gameObject.transform.position + new Vector3(movementSpeed * Time.deltaTime, 0, 0);
            if (gameObject.transform.position.x >= originalPos2.x) {
                forward = false;
                gameObject.transform.position = originalPos2;
            }
        }

        if (forward == false) {
            gameObject.transform.position = gameObject.transform.position + new Vector3(-movementSpeed * Time.deltaTime, 0, 0);
            if (gameObject.transform.position.x <= originalPos1.x) {
                forward = true;
                gameObject.transform.position = originalPos1;
            }
        }
    }
}
