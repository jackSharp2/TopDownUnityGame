using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetMovement : MonoBehaviour
{
    private Transform tr;

    void Start()
    {
        // Get the object's transform
        tr = transform;
    }

    void Update()
    {
        // Get the mouse position in screen space
        Vector3 mousePos = Input.mousePosition;
        Vector3 worldPos = Camera.main.ScreenToWorldPoint(mousePos);

        //moving the target
        tr.position = worldPos;
    }
}





