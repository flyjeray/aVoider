using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_Attack_ThreeSideShot : Enemy_Attack_ParentScript
{
    public override IEnumerator Attack()
    {
        yield return new WaitForSeconds(enemyData.attackPrepareTime);

        Vector3 vectorUp = new Vector3(Vector3.up.x, Vector3.up.y, 1);
        Vector3 vectorDownLeft = new Vector3(Vector3.down.x - 1, Vector3.down.y, 1);
        Vector3 vectorDownRight = new Vector3(Vector3.down.x + 1, Vector3.down.y, 1);

        List<Vector3> vectors = new List<Vector3>(new Vector3[] { vectorDownLeft, vectorDownRight, vectorUp } );

        foreach (Vector3 vector in vectors) Shoot(vector);
    }

    private void Shoot(Vector3 direction)
    {
        GameObject bullet = Instantiate(enemyData.bullet, spawnPos, Quaternion.identity, enemyData.bulletPackage);

        bullet.GetComponent<Enemy_Bullet_ShootInSettedDirection>().SetDirection(direction);
        bullet.GetComponent<Enemy_Bullet_ShootInSettedDirection>().Execute();
    }
}
