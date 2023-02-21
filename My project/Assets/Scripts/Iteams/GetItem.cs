using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GetItem : MonoBehaviour
{

    [SerializeField]
    public TMPro.TextMeshProUGUI matTextCommon;
    [SerializeField]
    public TMPro.TextMeshProUGUI matTextRare;
    int rareAmount = 0;
    int commonAmount = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public int getType(int type) 
    {
        Debug.Log("test");
        switch (type) 
        {
            case 1:
                commonAmount += 1;
                matTextCommon.text = "" + commonAmount;
                break;
            case 2:
                rareAmount += 1;
                matTextRare.text = "" + rareAmount;
                break;
            case 3:
                break;
            case 4:
                break;
        }
        return 1;
    }
}
