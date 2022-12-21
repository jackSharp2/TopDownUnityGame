using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMain : MonoBehaviour
{
    // declaring variables
    PlayerRotaions rotation;

    void Start()
    {
        GameObject body = GameObject.Find("PlayerBody");
        rotation = body.GetComponent<PlayerRotaions>();
    }


    void Update()
    {
        rotation.FaceMouse();
    }
}
