﻿
using UnityEngine;

public class AudioSourceMovement2 : MonoBehaviour
{
    private float rotationSpeed = 1.5f;
    private float radius = 0.5f;
    private float angle;
    Vector3 originalPos;

    void Start()
    {
        originalPos = new Vector3(gameObject.transform.position.x, gameObject.transform.position.y, gameObject.transform.position.z);
    }

    // Update is called once per frame
    void Update()
    {
        angle += rotationSpeed * Time.deltaTime;
        var offset = new Vector3(Mathf.Sin(angle), 0f, Mathf.Cos(angle) * radius);
        gameObject.transform.position = originalPos + offset;
    }
}
