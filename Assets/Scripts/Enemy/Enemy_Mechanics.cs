using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Enemy_DataContainer))]
public class Enemy_Mechanics : MonoBehaviour
{
    private Enemy_DataContainer enemyData;    

    [SerializeField] private Enemy_Attack_ParentScript[] attacks;
    [SerializeField] private Game_DataContainer gameData;

    private void Awake()
    {
        enemyData = GetComponent<Enemy_DataContainer>();

        StartCoroutine(Attacks());
    }

    private IEnumerator Attacks()
    {
        while (gameData.isGameOn)
        {
            attacks[UnityEngine.Random.Range(0, attacks.Length)].Execute();
            gameData.playerScore++;

            yield return new WaitForSeconds(enemyData.pauseBetweenShooting);
        }        
    }
}
