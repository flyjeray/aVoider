using System.Collections;
using System.Collections.Generic;
using TreeEditor;
using UnityEngine;

public class Enemy_Bullet_SIP_Mechanics : Enemy_Bullet_ParentScript
{
    private bool isAttackStarted = false;
    private Vector3 destination;

    public override void Attack()
    {
        destination = enemyData.player.position;
        isAttackStarted = true;
    }

    private void FixedUpdate()
    {
        if (isAttackStarted)
        {
            if (transform.position == destination) Destroy(gameObject);
            transform.position = Vector3.MoveTowards(transform.position, destination, enemyData.bulletSpeed * Time.fixedDeltaTime);
        }
    }
}
