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

            case 1:
                return luck;

            case 2:
                return health;

            case 3:
                return damage;

            case 4:
                return critChance;

            case 5:
                return critDamage;
        }
        return 0;
    }
}
