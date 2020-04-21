
using UnityEngine;

public class AudioSourceMovement2 : MonoBehaviour
{
    public GameObject playerOb;

    private float rotationSpeed = 0.5f;
    private float radius = 8.0f;
    private float angle;

    Vector3 originalPos;

    void Start()
    {
        //originalPos = new Vector3(gameObject.transform.position.x, gameObject.transform.position.y, gameObject.transform.position.z);
    }

    // Update is called once per frame
    void Update()
    {

        angle += rotationSpeed * Time.deltaTime;
        var offset = new Vector3(Mathf.Sin(angle) * radius, 0f, Mathf.Cos(angle) * radius);
        gameObject.transform.position = playerOb.transform.position + offset;
    }
}
