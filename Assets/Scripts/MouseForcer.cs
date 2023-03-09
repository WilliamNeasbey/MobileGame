using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseForcer : MonoBehaviour
{
    //For initialization
    void Awake()
    {
        Cursor.visible = true;

    }

    // Update is called once per frame
    void Update()
    {
        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.None;
    }
}
