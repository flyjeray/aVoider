using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Enemy_DataContainer))]
public abstract class Enemy_Attack_ParentScript : MonoBehaviour
{
    public Enemy_DataContainer enemyData;
    public Vector3 spawnPos;
    private void Awake()
    {
        spawnPos = new Vector3(transform.position.x, transform.position.y, 1);
        enemyData = GetComponent<Enemy_DataContainer>();
    }

    public void Execute()
    {
        StartCoroutine(Attack());
    }

    public abstract IEnumerator Attack();
}
