using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_Attack_ShootInPlayer : Enemy_Attack_ParentScript
{
    public override IEnumerator Attack()
    {
        yield return new WaitForSeconds(enemyData.attackPrepareTime);

        for (int i = 0; i < enemyData.amountOfBullets; i++)
        {
            GameObject bullet = Instantiate(enemyData.bullet, transform.position, Quaternion.identity, enemyData.bulletPackage);
            bullet.GetComponent<Enemy_Bullet_SIP_Mechanics>().Execute();
        }
    }
}
