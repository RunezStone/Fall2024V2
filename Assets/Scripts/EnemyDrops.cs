using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDrops : MonoBehaviour
{
    public Item item;

    private SpriteRenderer spriteRenderer;

    void Awake()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        spriteRenderer.sprite = item.ItemDisplay;
    }


    EnemyDrops(Item item) 
    { 
        this.item = item;
        spriteRenderer.sprite = item.ItemDisplay;
    
    }
}
