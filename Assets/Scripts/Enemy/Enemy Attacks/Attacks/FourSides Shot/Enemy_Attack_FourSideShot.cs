using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_Attack_FourSideShot : Enemy_Attack_ParentScript
{
    public override IEnumerator Attack()
    {
        yield return new WaitForSeconds(enemyData.attackPrepareTime);

        StartCoroutine(ShootInOneSide(Vector2.up));
        StartCoroutine(ShootInOneSide(Vector2.right));
        StartCoroutine(ShootInOneSide(Vector2.down));
        StartCoroutine(ShootInOneSide(Vector2.left));
    }

    private IEnumerator ShootInOneSide(Vector2 direction)
    {
        for (int i = 0; i < enemyData.amountOfBullets_FourSideShot; i++)
        {
            GameObject bullet = Instantiate(enemyData.bullet, transform.position, Quaternion.identity, enemyData.bulletPackage);
            bullet.GetComponent<Enemy_Bullet_FourSideShot_Mechanics>().SetDirection(direction);
            bullet.GetComponent<Enemy_Bullet_FourSideShot_Mechanics>().Execute();

            yield return new WaitForSeconds(enemyData.periodOfShooting);
        }
    }
}
