using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Collections : MonoBehaviour
{
    public TMPro.TMP_Text matterialText;
    public int num = 10;

    void Awake()
    {
        matterialText = GameObject.Find("ItemSlot").GetComponentInChildren<TextMeshProUGUI>();
    }

    public void Update()
    {

        matterialText.text = "" + num;
    }

}
