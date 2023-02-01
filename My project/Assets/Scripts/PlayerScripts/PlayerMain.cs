using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMain : MonoBehaviour
{
    // declaring variables
    public CharacterController controller;
    private float movementSpeed = 5;
    private int speed = 0;
    private int luck = 1;
    private int health = 100;
    private int damage = 10;
    private int critChance = 5;
    private int critDamage = 2;

    //simple movement script
    public void Movement(Vector3 direction)
    {
        controller.Move(direction * movementSpeed * Time.deltaTime);
    }

    public int GetStats(int stat) 
    {
        switch (stat) 
        {
            case 0:
                return speed;
                break;

            case 1:
                return luck;
                break;

            case 2:
                return health;
                break;

            case 3:
                return damage;
                break;

            case 4:
                return critChance;
                break;

            case 5:
                return critDamage;
                break;
        }
        return 0;
    }
}
