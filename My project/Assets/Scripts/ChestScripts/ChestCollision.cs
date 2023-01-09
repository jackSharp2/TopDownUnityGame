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
        chest = GameObject.Find("LargeChest");
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
            iteams.getDrops(chest);
            Destroy(chest);
        }
    }
}
