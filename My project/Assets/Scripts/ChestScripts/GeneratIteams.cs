using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GeneratIteams : MonoBehaviour
{
    //setting up variables
    private int DropAmount = 0;
    private int DropType = 1;
    private int DropRarity = 0;
    private float DropXChange;
    private float DropZChange;
    private Vector3 DropRange;

    //getting the prefabs
    public GameObject legendary;
    public GameObject epic;
    public GameObject rare;
    public GameObject common;

    public void getDrops(GameObject chest) 
    {
        if (chest.tag == "LargChest")
        {
            //getting the amount i want to drop
            DropAmount = Random.Range(0, 10);
            for (int i = 0; i <= DropAmount; i++)
            {
                //getting the type and value of each iteam
                DropType = Random.Range(0, 5);
                DropRarity = Random.Range(0, 50);
                DropXChange = Random.Range(-2f, 2f);
                DropZChange = Random.Range(-2f, 2f);
                DropRange = new Vector3(chest.transform.position.x + DropXChange, chest.transform.position.y, chest.transform.position.z + DropZChange);

                //weapons = 0
                if (DropType == 0)
                {
                    //legendary = 6%, epic = 16%, rare = 36%, common = 42%
                    if (DropRarity <= 3)
                    {
                        Instantiate(legendary, DropRange, Quaternion.identity);
                    }
                    else if (DropRarity <= 8)
                    {
                        Instantiate(epic, DropRange, Quaternion.identity);
                    }
                    else if (DropRarity <= 18)
                    {
                        Instantiate(rare, DropRange, Quaternion.identity);
                    }
                    else
                    {
                        Instantiate(common, DropRange, Quaternion.identity);
                    }
                }
                //mattirials =  1 to 5
                else
                {
                    if (DropRarity == 1)
                    {
                        Instantiate(legendary, DropRange, Quaternion.identity);
                    }
                    else if (DropRarity <= 5)
                    {
                        Instantiate(epic, DropRange, Quaternion.identity);
                    }
                    else if (DropRarity <= 13)
                    {
                        Instantiate(rare, DropRange, Quaternion.identity);
                    }
                    else
                    {
                        Instantiate(common, DropRange, Quaternion.identity);
                    }
                }
            }
        }
        else if (chest.tag == "SmallChest") 
        {
            //getting the amount i want to drop
            DropAmount = Random.Range(0, 5);
            for (int i = 0; i <= DropAmount; i++)
            {
                //getting the type and value of each iteam
                DropType = Random.Range(0, 5);
                DropRarity = Random.Range(0, 50);
                DropXChange = Random.Range(-2f, 2f);
                DropZChange = Random.Range(-2f, 2f);
                DropRange = new Vector3(chest.transform.position.x + DropXChange, chest.transform.position.y, chest.transform.position.z + DropZChange);

                //weapons = 0
                if (DropType == 0)
                {
                    //legendary = 2%, epic = 10%, rare = 26%, common = 62%
                    if (DropRarity == 1)
                    {
                        Instantiate(legendary, DropRange, Quaternion.identity);
                    }
                    else if (DropRarity <= 5)
                    {
                        Instantiate(epic, DropRange, Quaternion.identity);
                    }
                    else if (DropRarity <= 13)
                    {
                        Instantiate(rare, DropRange, Quaternion.identity);
                    }
                    else
                    {
                        Instantiate(common, DropRange, Quaternion.identity);
                    }
                }
                //mattirials =  1 to 5
                else
                {
                    if (DropRarity == 1)
                    {
                        Instantiate(legendary, DropRange, Quaternion.identity);
                    }
                    else if (DropRarity <= 5)
                    {
                        Instantiate(epic, DropRange, Quaternion.identity);
                    }
                    else if (DropRarity <= 13)
                    {
                        Instantiate(rare, DropRange, Quaternion.identity);
                    }
                    else
                    {
                        Instantiate(common, DropRange, Quaternion.identity);
                    }
                }
            }
        }
        Destroy(chest);
    }
}
