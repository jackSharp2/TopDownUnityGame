using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMain : MonoBehaviour
{
    // declaring variables
    public CharacterController controller;
    private float speed = 5f;

    void Start()
    {
        
    }


    void Update()
    {
        
    }

    //simple movement script
    public void Movement(Vector3 direction)
    {
        controller.Move(direction * speed * Time.deltaTime);
    }
}
