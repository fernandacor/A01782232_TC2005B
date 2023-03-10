using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sineMovement : MonoBehaviour
{
    [SerializeField] float amplitude;
    [SerializeField] float speed;
    Vector3 initialPosition;
    Vector3 offset;
    float angle;

    void Start()
    {
        initialPosition = transform.position;
    }

    void Update()
    {
        angle += speed * Time.deltaTime;
        offset = new Vector3(Mathf.Sin(angle) * amplitude, 0, 0);
        transform.position = initialPosition + offset;
    }
}