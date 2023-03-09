using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraSwitcher : MonoBehaviour
{
    [SerializeField] private Camera[] cameras;
    private int currentCameraIndex = 0;
    [SerializeField] private float switchTime = 5f;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(SwitchCameras());
    }

    private IEnumerator SwitchCameras()
    {
        while (true)
        {
            yield return new WaitForSeconds(switchTime);

            cameras[currentCameraIndex].enabled = false;
            currentCameraIndex = (currentCameraIndex + 1) % cameras.Length;
            cameras[currentCameraIndex].enabled = true;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
