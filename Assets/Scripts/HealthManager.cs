using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.UI;


public class NewBehaviourScript : MonoBehaviour
{

    public Image healthBar;
    public float healthAmount = 80f;

    public void takeDamage(float damage)
    {
        healthAmount -= damage;

        healthBar.fillAmount = healthAmount / 100;

    }

    public void Heal(float healingAmount)
    {
        healthAmount += healingAmount;

        healthAmount = Mathf.Clamp(healthAmount, 0, 100);

        healthBar.fillAmount = healthAmount / 100;


    }

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        if (healthAmount <= 0)
        {
            Application.LoadLevel(Application.loadedLevel);
        }

        if (Input.GetKeyDown(KeyCode.D))
        {
            //Debug.Log("damage key pressed");
            takeDamage(20);
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            //Debug.Log("heal key pressed");
            Heal(5);
        }

    }
}
