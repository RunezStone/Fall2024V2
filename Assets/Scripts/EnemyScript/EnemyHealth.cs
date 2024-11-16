using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{

    public GameObject healthBar;
    public Rigidbody2D rb;

    [SerializeField]
    private float maxHealth = 100f;
    private float currHealth;

    void Start()
    {
        currHealth = maxHealth;
        rb = GetComponent<Rigidbody2D>();
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.tag == "Hit")
        {
            TakeDamage(collision.GetComponent<HitData>().damage);
            CheckDead();
        }

    }

    private void TakeDamage(float damage)
    {
        currHealth = currHealth - damage;

        float barSize = ((maxHealth - currHealth)/ maxHealth) * -1;
        healthBar.transform.localScale += new Vector3(barSize, 0, 0);
    }

    private void CheckDead()
    {
        Debug.Log("Enemy Health: " + currHealth);
        if (currHealth <= 0)
        {
            Debug.Log("Enemy is DEAD");
            Destroy(gameObject);
        }
    }

}
