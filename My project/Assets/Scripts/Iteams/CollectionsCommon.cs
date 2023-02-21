using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class CollectionsCommon : MonoBehaviour
{

    GetItem item;

    void Start() 
    {
        GameObject gameManager = GameObject.Find("GameManager");
        item = gameManager.GetComponent<GetItem>();
    }
    void OnCollisionEnter(Collision collision)
    {
        
        // Get the tag of the colliding object
        string tag = collision.gameObject.tag;
        if (tag == "Player")
        {
            item.getType(1);
        }
    }

}
