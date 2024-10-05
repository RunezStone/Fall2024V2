using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class EnemyStateBase 
{
    abstract public void EnterState(EnemyBehavManager manager);

    abstract public void UpdateState(EnemyBehavManager manager);


}
