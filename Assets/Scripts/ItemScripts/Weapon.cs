using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu]
public class Weapon : Item
{
    private float durability;

    public GameObject bulletPrefab;
    public WeaponBehavior weaponBehavior;


    private int maxAmmo = 10;
    private int currAmmo = 0;

    public Weapon(float currDurability, int currAmmo)
    {
        this.durability = currDurability;
        this.currAmmo = currAmmo;
    }

    public override void UseItem()
    {
        currAmmo--;
        if (currAmmo <= 0)
        {
            Reload();
        }
    }

    public void Reload()
    {
        if (maxAmmo > currAmmo)
        {
            currAmmo = maxAmmo;
        }
    }
}
