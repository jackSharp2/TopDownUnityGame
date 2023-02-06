using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkillTreeScript : MonoBehaviour
{
    public GameObject skilltree;

    public void Hide()
    {
        skilltree.gameObject.SetActive(false);
    }

    public void Show()
    {
        skilltree.gameObject.SetActive(true);
    }

    void Start()
    {
        Hide(); 
    }
}
