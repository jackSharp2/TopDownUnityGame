using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GetItem : MonoBehaviour
{

    [SerializeField]
    public TMPro.TextMeshProUGUI matTextCommon;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void getType(int type) 
    {
        Debug.Log("test");
        if (type < 0)
        {
            matTextCommon.text = "Enter Your Text Here";
        }
        else 
        {
            matTextCommon.text = "Enter Your Text Here";
        }
    }
}
