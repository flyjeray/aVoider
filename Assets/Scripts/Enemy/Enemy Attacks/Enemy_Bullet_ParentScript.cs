using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Enemy_Bullet_ParentScript : MonoBehaviour
{
    public Enemy_DataContainer enemyData;

    private void Awake()
    {
        if (gameObject.transform.parent.name != "Reference") Destroy(gameObject, enemyData.timeToDestroy);
    }    

    private void OnCollisionEnter2D(Collision2D collider)
    {
        if (collider.gameObject.GetComponent<Player_Mechanics>() != null)
        {
            Player_Mechanics player = collider.gameObject.GetComponent<Player_Mechanics>();
                        
            player.GetDamage();
            Destroy(gameObject);
        }
    }

    public void Execute()
    {
        if (transform.parent.name != "Reference") Attack();
    }

    public abstract void Attack();
}
