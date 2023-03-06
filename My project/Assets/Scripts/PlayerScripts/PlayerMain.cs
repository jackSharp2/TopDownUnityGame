using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMain : MonoBehaviour
{
    // declaring variables
    public CharacterController controller;
    public int statChange = 0;
    private float movementSpeed = 5;
    //crit, luck , health, dmg, crit chance
    private int[] skills = {2, 1, 100, 10, 5};

    void start() 
    {
    }
    //simple movement script
    public void Movement(Vector3 direction)
    {
        controller.Move(direction * movementSpeed * Time.deltaTime);
    }

    public void ChangeStats(int stat, int statChange)
    {

        stat = GetStats(stat);
        stat += statChange;
    }

    public int GetStats(int stat) 
    {
        switch (stat) 
        {
            case 0:
                return skills[stat];
            case 1:
                return skills[stat];
            case 2:
                return skills[stat];
            case 3:
                return skills[stat];
            case 4:
                return skills[stat];
        }
        return 0;
    }
}
