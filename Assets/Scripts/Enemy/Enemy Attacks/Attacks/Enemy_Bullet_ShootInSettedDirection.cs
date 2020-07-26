using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_Bullet_ShootInSettedDirection : Enemy_Bullet_ParentScript
{
    private bool isAttackStarted = false;
    private Vector3 movementDirection;

    public void SetDirection(Vector3 newDirection)
    {
        movementDirection = newDirection;
    }

    public override void Attack()
    {
        isAttackStarted = true;
    }

    private void FixedUpdate()
    {
        if (isAttackStarted)
        {
            transform.Translate(movementDirection * enemyData.bulletSpeed * Time.fixedDeltaTime);
        }
    }
}
