using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_Attack_FourSideShot : Enemy_Attack_ParentScript
{
    public override IEnumerator Attack()
    {
        yield return new WaitForSeconds(enemyData.attackPrepareTime);

        float vectorChange = UnityEngine.Random.Range(-1, 1);
        Debug.Log(vectorChange);

        Vector2 vectorUpChanged = new Vector2(Vector2.up.x + vectorChange, Vector2.up.y);
        Vector2 vectorDownChanged = -vectorUpChanged;

        Vector2 vectorRightChanged = new Vector2(Vector2.right.x, Vector2.right.y - vectorChange);
        Vector2 vectorLeftChanged = -vectorRightChanged;

        List<Vector2> vectors = new List<Vector2>(new Vector2[] { vectorUpChanged, vectorDownChanged, vectorRightChanged, vectorLeftChanged } );

        for (int i = 0; i < vectors.Count; i++) StartCoroutine(ShootInOneSide(vectors[i]));
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
