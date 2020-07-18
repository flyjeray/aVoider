using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Enemy_Bullet_ParentScript : MonoBehaviour
{
    public Enemy_DataContainer enemyData;
    public bool isReference;

    private void Awake()
    {
        if (transform.parent.name == "Reference") isReference = true;
        else isReference = false;
    }    

    private void OnCollisionEnter2D(Collision2D collider)
    {
        if (collider.gameObject.GetComponent<Player_DataContainer>() != null)
        {
            collider.gameObject.GetComponent<Player_DataContainer>().hp--;
            Destroy(gameObject);
        }
    }

    public void Execute()
    {
        if (transform.parent.name != "Reference") Attack();
    }

    public abstract void Attack();
}
