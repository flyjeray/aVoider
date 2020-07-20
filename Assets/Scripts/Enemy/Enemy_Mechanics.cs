using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Enemy_DataContainer))]
public class Enemy_Mechanics : MonoBehaviour
{
    private Enemy_DataContainer enemyData;    

    [SerializeField] private Enemy_Attack_ParentScript[] attacks;
    [SerializeField] private Game_Controller gameController;

    private void Awake()
    {
        enemyData = GetComponent<Enemy_DataContainer>();

        StartCoroutine(Attacks());
    }

    private IEnumerator Attacks()
    {
        while (gameController.gameData.isGameOn)
        {
            attacks[UnityEngine.Random.Range(0, attacks.Length)].Execute();            

            yield return new WaitForSeconds(enemyData.pauseBetweenShooting);
            gameController.gameData.playerScore++;
            gameController.UpdateScoreText();
        }        
    }
}
