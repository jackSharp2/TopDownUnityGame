using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Collections : MonoBehaviour
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
        string thisTag = gameObject.tag;
        string tag = collision.gameObject.tag;
        if (tag == "Player")
        {

            switch (thisTag) 
            {
                case "Common":
                    Destroy(parent);
                    item.getType(0);
                    break;
                case "Rare":
                    Destroy(parent);
                    item.getType(1);
                    break;
                case "Epic":
                    Destroy(parent);
                    item.getType(2);
                    break;
                case "Legondary":
                    Destroy(parent);
                    item.getType(3);
                    break;
            }
        }
    }

}
