using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class BulletData : ScriptableObject
{
    float damage = 10f;
    public Type damageType;

    void OnTriggerEnter()
    {
        Destroy(this);
    }

}
