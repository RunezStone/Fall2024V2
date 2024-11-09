using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collision : MonoBehaviour
{

    public GameObject healthBar;
    // Start is called before the first frame update
    void Start()
    {
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {

        float dmg = .1f;

        if(collision.tag == "Player")
        {
            healthBar.transform.localScale += new Vector3(-dmg, 0, 0);
        }
         
        /*
        GameObject pewdiepie = GameObject.Find("pewdiepie");
        GameObject healthbar = GameObject.Find("Healthbar");
        GameObject green = healthbar.transform.GetChild(0).gameObject;
        GameObject.Destroy(pewdiepie);
        Debug.Log("hit");
        green.transform.localScale += new Vector3(-dmg,0,0);
        */
        
    }
    // Update is called once per frame
    void Update()
    {
    }

}

