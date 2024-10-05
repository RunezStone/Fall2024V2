using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private float health = 100f;

    public float currHealth = 100f;

    

    public void TakeDamage(float damage)
    {
        currHealth = currHealth - damage;
        if (currHealth < health)
        {
            Death();
        }
    }
    public void Heal(float hp)
    {
        currHealth = currHealth + hp;
        if (currHealth > health)
        {
            currHealth = health;
        }
    }

    private void Death()
    {
        Console.WriteLine("The Player is dead :(");
    }

}
