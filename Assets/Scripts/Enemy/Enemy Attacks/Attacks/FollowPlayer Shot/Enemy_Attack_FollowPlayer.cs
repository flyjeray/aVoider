using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_Attack_FollowPlayer : Enemy_Attack_ParentScript
{
    public override IEnumerator Attack()
    {
        yield return new WaitForSeconds(enemyData.attackPrepareTime);
        GameObject bullet = Instantiate(enemyData.bullet, spawnPos, Quaternion.identity, enemyData.bulletPackage);
        bullet.GetComponent<Enemy_Bullet_FollowPlayer>().Execute();
    }
}
