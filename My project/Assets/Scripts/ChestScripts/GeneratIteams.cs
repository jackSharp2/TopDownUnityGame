using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GeneratIteams : MonoBehaviour
{
    //setting up variables
    private int DropAmount = 0;
    private int DropType = 1;
    private int DropRarity = 0;

    //getting the prefabs
    public GameObject legendary;
    public GameObject epic;
    public GameObject rare;
    public GameObject common;

    public void getDrops(GameObject chest) 
    {
        if(chest.tag == "LargChest") { 
            //getting the amount i want to drop
            DropAmount = Random.Range(0, 10);
            for (int i = 0; i <= DropAmount; i++) 
            {
                //getting the type and value of each iteam
                DropType = Random.Range(0, 5);
                DropRarity = Random.Range(0, 50);

                //weapons = 0
                if (DropType == 0)
                {
                    //legendary = 2%, epic = 10%, rare = 26%, common = 62%
                    if (DropRarity == 1)
                    {
                        Instantiate(legendary, chest.transform.position, Quaternion.identity);
                    }
                    else if (DropRarity <= 5)
                    {
                        Instantiate(epic, chest.transform.position, Quaternion.identity);
                    }
                    else if (DropRarity <= 13)
                    {
                        Instantiate(rare, chest.transform.position, Quaternion.identity);
                    }
                    else 
                    {
                        Instantiate(common, chest.transform.position, Quaternion.identity);
                    }
                }
                //mattirials =  1 to 5
                else 
                {
                    if (DropRarity == 1)
                    {
                        Instantiate(legendary, chest.transform.position, Quaternion.identity);
                    }
                    else if (DropRarity <= 5)
                    {
                        Instantiate(epic, chest.transform.position, Quaternion.identity);
                    }
                    else if (DropRarity <= 13)
                    {
                        Instantiate(rare, chest.transform.position, Quaternion.identity);
                    }
                    else
                    {
                        Instantiate(common, chest.transform.position, Quaternion.identity);
                    }
                }
            }
        }
    }
}
