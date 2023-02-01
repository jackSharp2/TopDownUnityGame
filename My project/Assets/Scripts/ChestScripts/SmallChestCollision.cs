using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SmallChestCollision : MonoBehaviour
{
    GameObject chest;
    GeneratIteams iteams;
    void Start()
    {
        chest = GameObject.Find("SmallChest");
        iteams = chest.GetComponent<GeneratIteams>();
    }

    // Update is called once per frame
    void Update()
    {
    }

    void OnCollisionEnter(Collision collision)
    {
        // Get the tag of the colliding object
        // Destroy(chest);
        string tag = collision.gameObject.tag;
        if (tag == "Player")
        {
            iteams.getDrops(chest,0);
            Destroy(chest);
        }
    }
}
