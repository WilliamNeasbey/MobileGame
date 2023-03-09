using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackAndFoward : MonoBehaviour
{
    public float speed = 2f; // speed of movement
    public float distance = 5f; // distance to move left and right

    private Vector3 startPosition; // starting position of object

    void Start() {
        // save the starting position of the object
        startPosition = transform.position;
    }

    void Update() {
        // calculate the current position based on time
        float t = Mathf.PingPong(Time.time * speed, distance * 2) - distance;
        Vector3 currentPos = startPosition + new Vector3(t, 0, 0);

        // move the object to the current position
        transform.position = currentPos;
    }
}
