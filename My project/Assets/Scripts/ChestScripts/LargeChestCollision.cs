using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LargeChestCollision : MonoBehaviour
{
    // Start is called before the first frame update
    GameObject chest;
    GeneratIteams iteams;
    GameObject player;
    PlayerMain playermain;
    void Start()
    {
        player = GameObject.Find("Player");
        chest = GameObject.Find("LargeChest");
        iteams = chest.GetComponent<GeneratIteams>();
        playermain = player.GetComponent<PlayerMain>();
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
            int luck = playermain.GetStats(1);
            iteams.getDrops(chest, luck);
            Destroy(chest);
        }
    }
}
