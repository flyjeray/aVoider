using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_Attack_ShootInPlayer : Enemy_Attack_ParentScript
{
    public override IEnumerator Attack()
    {
        yield return new WaitForSeconds(enemyData.attackPrepareTime);

        enemyData.amountOfBullets_SIP = UnityEngine.Random.Range(2, 4);
        for (int i = 0; i < enemyData.amountOfBullets_SIP; i++)
        {
            GameObject bullet = Instantiate(enemyData.bullet, spawnPos, Quaternion.identity, enemyData.bulletPackage);
            bullet.GetComponent<Enemy_Bullet_SIP_Mechanics>().Execute();

            yield return new WaitForSeconds(enemyData.periodOfShooting);
        }
    }
}
