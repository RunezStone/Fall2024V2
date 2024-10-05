using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnTowardTower : EnemyStateBase
{
    public override void EnterState(EnemyBehavManager manager)
    {

    }

    public override void UpdateState(EnemyBehavManager manager)
    {
        manager.direction = new Vector2(manager.towerPos.position.x - manager.transform.position.x, manager.towerPos.position.y - manager.transform.position.y);

        manager.rb.velocity = manager.direction * manager.moveSpeed * Time.deltaTime;

        if(Mathf.Abs(manager.towerPos.position.x - manager.transform.position.x) < manager.towDistance ||
            Mathf.Abs(manager.towerPos.position.y - manager.transform.position.y) < manager.towDistance)
        {
            manager.SwitchState(manager.attackTower);
        }
    }
}
