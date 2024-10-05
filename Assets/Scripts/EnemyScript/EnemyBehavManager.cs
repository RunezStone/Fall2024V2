using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[RequireComponent(typeof(Rigidbody2D))]

public class EnemyBehavManager : MonoBehaviour
{
    public float moveSpeed = 1.0f;
    public Transform towerPos;
    public Rigidbody2D rb;


    public float towDistance;
    public float playerDistance;

    public Vector2 direction;

    EnemyStateBase currState;

    public EnemyStateBase attackPlayer = new EnAttackPlayer();
    public EnemyStateBase attackTower = new EnAttackTower();
    public EnemyStateBase towardsTower = new EnTowardTower();
    public EnemyStateBase towardsPlayer = new EnTowardPlayer();

    void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        currState = towardsTower;
        currState.EnterState(this);
    }

    public void FixedUpdate()
    {
        currState.UpdateState(this);
    }

    public void SwitchState(EnemyStateBase newBase)
    {
        currState = newBase;
        currState.EnterState(this);
    }

    
}
