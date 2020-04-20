using UnityEngine;

public class AudioSourceMovement4 : MonoBehaviour {
    private float movementSpeed = 1.5f;
    Vector3 originalPos;

    void Start () {
        originalPos = new Vector3(gameObject.transform.position.x, gameObject.transform.position.y, gameObject.transform.position.z);
    }

    // Update is called once per frame
    void Update () {
        gameObject.transform.position = gameObject.transform.position + new Vector3(-movementSpeed * Time.deltaTime, 0, 0);

        if (gameObject.transform.position.x <= 15) {
            gameObject.transform.position = originalPos;
        }
    }
}