using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_Attack_FourSideShot : Enemy_Attack_ParentScript
{
    public override IEnumerator Attack()
    {
        yield return new WaitForSeconds(enemyData.attackPrepareTime);

        enemyData.amountOfBullets_FourSideShot = UnityEngine.Random.Range(2, 4);

        float vectorChange = UnityEngine.Random.Range(-1, 1);

        Vector3 vectorUpChanged = new Vector3(Vector3.up.x + vectorChange, Vector3.up.y, 1);
        Vector3 vectorDownChanged = -vectorUpChanged;

        Vector3 vectorRightChanged = new Vector3(Vector3.right.x, Vector3.right.y - vectorChange, 1);
        Vector3 vectorLeftChanged = -vectorRightChanged;

        List<Vector3> vectors = new List<Vector3>(new Vector3[] { vectorUpChanged, vectorDownChanged, vectorRightChanged, vectorLeftChanged } );

        for (int i = 0; i < vectors.Count; i++) StartCoroutine(ShootInOneSide(vectors[i]));
    }

    private IEnumerator ShootInOneSide(Vector3 direction)
    {
        for (int i = 0; i < enemyData.amountOfBullets_FourSideShot; i++)
        {
            GameObject bullet = Instantiate(enemyData.bullet, spawnPos, Quaternion.identity, enemyData.bulletPackage);
            bullet.GetComponent<Enemy_Bullet_FourSideShot_Mechanics>().SetDirection(direction);
            bullet.GetComponent<Enemy_Bullet_FourSideShot_Mechanics>().Execute();

            yield return new WaitForSeconds(enemyData.periodOfShooting);
        }
    }
}
