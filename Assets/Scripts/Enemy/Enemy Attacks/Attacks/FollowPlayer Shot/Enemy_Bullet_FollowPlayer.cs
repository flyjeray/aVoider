using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_Bullet_FollowPlayer : Enemy_Bullet_ParentScript
{
    private bool isAttackStarted;
    private bool isDestinationReached;
    private bool isDirectionSetted;

    [SerializeField] private Player_DataContainer playerData;

    private Vector3 destination;
    private Vector3 direction;

    public override void Attack()
    {
        destination = enemyData.player.position;
        isAttackStarted = true;
    }

    private void FixedUpdate()
    {
        if (transform.position == destination) isDestinationReached = true;

        if (isAttackStarted && !isDestinationReached)
        {
            transform.position = Vector3.MoveTowards(transform.position, destination, enemyData.bulletSpeed * Time.fixedDeltaTime);
        }

        else if (isAttackStarted && isDestinationReached)
        {
            if (!isDirectionSetted) SetDirection();

            transform.RotateAround(playerData.centerOfRotation.position, direction, playerData.speed);
        }
    }

    private void SetDirection()
    {
        if (playerData.isClockwiseDirectioned) direction = Vector3.forward;
        else direction = Vector3.back;

        isDirectionSetted = true;
    }
}
