using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChestCollision : MonoBehaviour
{
    // Start is called before the first frame update
    GameObject chest;
    GeneratIteams iteams;
    void Start()
    {
        chest = GameObject.Find("ResorseChests");
        iteams = chest.GetComponent<GeneratIteams>();
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
            Destroy(chest);
            iteams.getDrops(chest);
        }
    }
}
