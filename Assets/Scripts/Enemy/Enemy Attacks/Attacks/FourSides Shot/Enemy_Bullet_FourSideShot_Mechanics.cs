using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_Bullet_FourSideShot_Mechanics : Enemy_Bullet_ParentScript
{
    private bool isAttackStarted = false;
    private Vector3 movementDirection;

    public void SetDirection(Vector2 newDirection)
    {        
        movementDirection = newDirection;
        Execute();
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
