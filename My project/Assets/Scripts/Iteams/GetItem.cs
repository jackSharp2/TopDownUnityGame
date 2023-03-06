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
    [SerializeField]
    public TMPro.TextMeshProUGUI matTextEpic;
    [SerializeField]
    public TMPro.TextMeshProUGUI matTextLegondary;
    //common, rare, epic, legond
    int[] ItemAmounts = { 0, 0, 0, 0 };
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
        switch (type) 
        {
            case 0:
                ItemAmounts[type] += 1;
                matTextCommon.text = "" + ItemAmounts[type];
                break;
            case 1:
                ItemAmounts[type] += 1;
                matTextRare.text = "" + ItemAmounts[type];
                break;
            case 2:
                ItemAmounts[type] += 1;
                matTextEpic.text = "" + ItemAmounts[type];
                break;
            case 3:
                ItemAmounts[type] += 1;
                matTextLegondary.text = "" + ItemAmounts[type];
                break;
        }
        return 1;
    }
}
