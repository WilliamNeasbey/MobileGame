using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraZoom : MonoBehaviour
{
    public Camera cam;
    public Transform target;
    public float minZoomDistance = 1f;
    public float maxZoomDistance = 10f;
    public float zoomDuration = 5f;

    private Vector3 startPosition;
    private float zoomTimer = 0f;

    private void Start()
    {
        startPosition = cam.transform.position;
    }

    private void Update()
    {
        // Update the zoom timer
        zoomTimer += Time.deltaTime;

        // Calculate the zoom distance based on the current zoom timer
        float t = zoomTimer / zoomDuration;
        float zoomDistance = Mathf.Lerp(minZoomDistance, maxZoomDistance, t);

        // Calculate the new position of the camera
        Vector3 newPosition = target.position - cam.transform.forward * zoomDistance;

        // Smoothly transition the camera position from the current position to the new position
        cam.transform.position = Vector3.Lerp(cam.transform.position, newPosition, Time.deltaTime * 10f);

        // Reset the zoom timer if it exceeds the zoom duration
        if (zoomTimer > zoomDuration)
        {
            zoomTimer = 0f;
            startPosition = cam.transform.position;
        }
    }
}
