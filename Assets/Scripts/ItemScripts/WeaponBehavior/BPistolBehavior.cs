using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BPistolBehavior : WeaponBehavior
{
    public override void Fire(GameObject bullet)
    {
        Instantiate(bullet, GameManager.Player.transform, GameManager.Player.GetComponent<PlayerMovement>().shootSpawn);
    }
}
