using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Stats_Menu_Script : MonoBehaviour
{
    [SerializeField] private PlayerPrefs_Controller prefsController;

    [SerializeField] private TextMeshProUGUI totalGamesText;
    [SerializeField] private TextMeshProUGUI averageLifeTimeText;
    [SerializeField] private TextMeshProUGUI totalCoinsText;

    private void Awake()
    {
        totalGamesText.text = prefsController.GetPlayedGames().ToString();
        averageLifeTimeText.text = prefsController.GetAverageTime().ToString();
        totalCoinsText.text = prefsController.GetTotalCoins().ToString();
    }
}
