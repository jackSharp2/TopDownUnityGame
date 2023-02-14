using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Collections : MonoBehaviour
{

    GetItem getitem;

    void start() 
    {
        GameObject gameManager = GameObject.Find("GameManager");
        getitem = gameManager.GetComponent<GetItem>();
    }
    void OnCollisionEnter(Collision collision)
    {
        // Get the tag of the colliding object
        string tag = collision.gameObject.tag;
        if (tag == "Player")
        {
            getitem.getType(1);
        }
    }

}
