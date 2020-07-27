using System.Collections;
using System.Collections.Generic;
using UnityEditor.MemoryProfiler;
using UnityEngine;

public abstract class Enemy_Bullet_ParentScript : MonoBehaviour
{
    public Enemy_DataContainer enemyData;

    private void Awake()
    {        
        if (gameObject.transform.parent.name != "Reference") Destroy(gameObject, enemyData.timeToDestroy);
    }

    public void Execute()
    {
        if (transform.parent.name != "Reference") Attack();
    }

    public abstract void Attack();
}
