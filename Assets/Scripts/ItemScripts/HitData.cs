using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
[RequireComponent(typeof(SpriteRenderer))]
public class HitData : MonoBehaviour
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
        

    public float GetDamage(Type type)
    {
        return damage;
    }

}
