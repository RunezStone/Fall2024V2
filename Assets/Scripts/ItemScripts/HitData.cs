using System.Collections;
using System.Collections.Generic;
using UnityEngine;

<<<<<<< Updated upstream:Assets/Scripts/ItemScripts/BulletData.cs
[RequireComponent(typeof(SpriteRenderer))]
[RequireComponent(typeof(CircleCollider2D))]
public class BulletData : MonoBehaviour
=======
[CreateAssetMenu]
[RequireComponent(typeof(SpriteRenderer))]
public class HitData : ScriptableObject
>>>>>>> Stashed changes:Assets/Scripts/ItemScripts/HitData.cs
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

<<<<<<< Updated upstream:Assets/Scripts/ItemScripts/BulletData.cs
    void OnTriggerEnter2D()
    {
        Destroy(gameObject);
    }
        
=======
    public int GetDamage(Type type)
    {

    }

>>>>>>> Stashed changes:Assets/Scripts/ItemScripts/HitData.cs
}
