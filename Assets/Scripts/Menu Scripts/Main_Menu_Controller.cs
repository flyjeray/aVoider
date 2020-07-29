using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

[RequireComponent(typeof(PlayerPrefs_Controller))]
public class Main_Menu_Controller : MonoBehaviour
{
    private PlayerPrefs_Controller prefsController;
    
    [SerializeField] private TextMeshProUGUI coinsText;
    [SerializeField] private TextMeshProUGUI bestScoreText;
    [SerializeField] private Image circleInLogo;

    private void Awake()
    {
        prefsController = GetComponent<PlayerPrefs_Controller>();
        circleInLogo.material = Resources.Load<Material>("Materials/" + prefsController.GetSkinName());

        UpdateTexts();
    }

    private void UpdateTexts()
    {
        coinsText.text = "Coins: " + prefsController.GetCoins();
        bestScoreText.text = "Best Score: " + prefsController.GetBestScore();
    }

    public void FullStatsRecoverButton()
    {
        prefsController.FullStatsRecover();
        UpdateTexts();
    }
}
