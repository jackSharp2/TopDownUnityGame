using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectingTree : MonoBehaviour
{
    public GameObject mageTree;
    public GameObject archerTree;
    public GameObject brawlerTree;

    public void HideMage()
    {
        mageTree.gameObject.SetActive(false);
    }
    public void ShowMage()
    {
        mageTree.gameObject.SetActive(true);
    }

    public void HideBrawler()
    {
        brawlerTree.gameObject.SetActive(false);
    }

    public void ShowBrawler()
    {
        brawlerTree.gameObject.SetActive(true);
    }

    public void HideArcher()
    {
        archerTree.gameObject.SetActive(false);
    }

    public void ShowArcher()
    {
        archerTree.gameObject.SetActive(true);
    }

    void Start()
    {
        mageTree.gameObject.SetActive(false);
        archerTree.gameObject.SetActive(false);
        brawlerTree.gameObject.SetActive(false);
    }
}
