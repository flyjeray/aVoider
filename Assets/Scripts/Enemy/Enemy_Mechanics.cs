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

    private Enemy_Attack_ParentScript lastAttack;
    private float streak;

    private void Awake()
    {
        enemyData = GetComponent<Enemy_DataContainer>();

        StartCoroutine(Attacks());
    }

    private IEnumerator Attacks()
    {
        while (gameController.gameData.isGameOn)
        {
            ChooseAttack().Execute();

            yield return new WaitForSeconds(enemyData.pauseBetweenShooting);
            gameController.gameData.playerScore++;
            gameController.UpdateScoreText();
        }        
    }

    private Enemy_Attack_ParentScript ChooseAttack()
    {
        Enemy_Attack_ParentScript chosenAttack = attacks[UnityEngine.Random.Range(0, attacks.Length)];

        if (chosenAttack == lastAttack && streak >= 2)
        {
            chosenAttack = ChooseAttack();
        }
        if (chosenAttack == lastAttack && streak < 2)
        {
            streak++;
        }
        if (chosenAttack != lastAttack)
        {
            lastAttack = chosenAttack;
            streak = 1;
        }

        return chosenAttack;
    }
}
