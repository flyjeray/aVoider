using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Enemy_DataContainer))]
public abstract class Enemy_Attack_ParentScript : MonoBehaviour
{
    [HideInInspector] public Enemy_DataContainer enemyData;

    private void Awake()
    {
        enemyData = GetComponent<Enemy_DataContainer>();
    }

    public void Execute()
    {
        StartCoroutine(Attack());
    }

    public abstract IEnumerator Attack();
}
