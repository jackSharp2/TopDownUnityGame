using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class CollectionsEpic: MonoBehaviour
{

    GetItem item;
    GameObject parent;
    void Start() 
    {
        GameObject gameManager = GameObject.Find("GameManager");
        item = gameManager.GetComponent<GetItem>();
        parent = transform.root.gameObject;
    }
    void OnCollisionEnter(Collision collision)
    {
        
        // Get the tag of the colliding object
        string tag = collision.gameObject.tag;
        if (tag == "Player")
        {
            Destroy(parent);
            item.getType(3);
        }
    }

}
