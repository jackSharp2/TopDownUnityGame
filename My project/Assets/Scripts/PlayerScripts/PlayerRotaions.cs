using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerRotaions : MonoBehaviour
{
    // declaring variables
    private Vector3 mousePos;
    private float rotSpeed = 100f;
    float rotation;
    private void Movement() 
    { 
    
    }


    public void FaceMouse() 
    {
        rotation = Input.GetAxis("Mouse Y") * rotSpeed * Time.deltaTime;
        rotation = Mathf.Clamp(rotation, 0, 360);
        transform.rotation = Quaternion.AngleAxis(rotation, Vector3.up);
    }
}
