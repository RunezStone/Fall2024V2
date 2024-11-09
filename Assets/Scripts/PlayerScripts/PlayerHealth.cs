using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHealth : MonoBehaviour
{

    public Slider healthSlider;
    public Slider easeHealthSlider;
    public float maxHealth = 100f;
    public float health;

    private float lerpSpeed = 3f;

    void Start()
    {
        health = maxHealth;
    }

    // Update is called once per frame
    void Update()
    {
        if (healthSlider.value != health)
        {
            healthSlider.value = health;
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            takeDamage(10);
        }


        if (healthSlider.value != easeHealthSlider.value)
        {
            //                                     initial            |  target           |   speedToTarget     
            easeHealthSlider.value = Mathf.Lerp(easeHealthSlider.value, healthSlider.value, lerpSpeed * Time.deltaTime);
        }
    }

    void takeDamage(float damage)
    {
        health = health - damage;
        checkDeath(health);
    }

    void checkDeath(float hp)
    {
        if (hp <= 0)
        {
            Debug.Log("Player is Dead");
        }
    }
}
