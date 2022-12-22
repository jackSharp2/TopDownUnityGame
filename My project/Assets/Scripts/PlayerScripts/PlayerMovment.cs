using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovment : MonoBehaviour
{
    //getting the camera, player transform and the player script
    private Camera mainCamera;

    PlayerMain player;
    Transform playerTransform;

    void Start() 
    {
        //getting the camera, player transform, player, and the player script
        mainCamera = FindObjectOfType<Camera>();

        GameObject playerFull = GameObject.Find("Player");
        player = playerFull.GetComponent<PlayerMain>();
        playerTransform = playerFull.GetComponent<Transform>();
    }

    void Update()
    {
        //creating a raycast for where I want my character to spin
        Ray ray = mainCamera.ScreenPointToRay(Input.mousePosition);
        Plane ground = new Plane(Vector3.up, Vector3.zero);
        float lenght;

        float x = playerTransform.position.x;
        float z = playerTransform.position.z;
        
        if (ground.Raycast(ray, out lenght)) 
        {
            //getting the ray cast point and looking at the point
            Vector3 point = ray.GetPoint(lenght);

            transform.LookAt(new Vector3(point.x, transform.position.y , point.z));
            transform.position = new Vector3(x, 1.1f, z);
        }

        //getting axes
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        //getting the direction I want to move in
        Vector3 direction = new Vector3(horizontal, 0f, vertical).normalized;

        if (direction.magnitude >= 0.1f)
        {
            //calling the move script and passing the direction
            player.Movement(direction);
        }

    }
}
