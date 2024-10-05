using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class EnAttackTower : EnemyStateBase
{
    public override void EnterState(EnemyBehavManager manager)
    {
        Debug.Log("Working");
        manager.rb.velocity = Vector2.zero;

    }

    public override void UpdateState(EnemyBehavManager manager)
    {

    }
}
