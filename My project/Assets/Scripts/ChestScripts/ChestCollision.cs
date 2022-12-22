using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChestCollision : MonoBehaviour
{
    // Start is called before the first frame update
    GameObject Chest;
    void Start()
    {
        Chest = GameObject.Find("ResorseChests");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter(Collision collision)
    {
        // Get the tag of the colliding object
        string tag = collision.gameObject.tag;

        if (tag == "Player")
        {
            Destroy(Chest);
        }
    }
}
