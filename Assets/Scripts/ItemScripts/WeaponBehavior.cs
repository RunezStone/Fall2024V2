using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class WeaponBehavior : MonoBehaviour
{
    [SerializeField]
    private float bulletForce = 20f;

    public abstract void Fire(GameObject bullet);
}
