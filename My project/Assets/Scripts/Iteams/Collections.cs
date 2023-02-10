using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collections : MonoBehaviour
{
    public Text counterText;
    public float counter;

    public void Update()
    {
        counterText.text = counter.ToString();
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
