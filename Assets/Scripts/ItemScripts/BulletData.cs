using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(SpriteRenderer))]
[RequireComponent(typeof(CircleCollider2D))]
public class BulletData : MonoBehaviour
{
    private SpriteRenderer sprite;

    public float damage = 10f;
    public Type damageType;

    public Sprite bullet;

    void Start()
    {
        sprite = GetComponent<SpriteRenderer>();
        sprite.sprite = bullet;
    }

    void OnTriggerEnter2D()
    {
        Destroy(gameObject);
    }
        
}
