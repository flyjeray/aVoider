using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

[RequireComponent(typeof(PlayerPrefs_Controller))]
public class Main_Menu_Controller : MonoBehaviour
{
    private PlayerPrefs_Controller prefsController;
    
    [SerializeField] private TextMeshProUGUI coinsText;
    [SerializeField] private TextMeshProUGUI bestScoreText;

    private void Awake()
    {
        prefsController = GetComponent<PlayerPrefs_Controller>();
        
        UpdateTexts();
    }

    private void UpdateTexts()
    {
        coinsText.text = "Coins: " + prefsController.GetCoins();
        bestScoreText.text = "Best Score: " + prefsController.GetBestScore();
    }

    public void PlayButton()
    {
        SceneManager.LoadScene("Game");
    }

    public void ShopButton()
    {
        SceneManager.LoadScene("Shop");
    }

    public void FullStatsRecoverButton()
    {
        prefsController.FullStatsRecover();
        UpdateTexts();
    }
}
