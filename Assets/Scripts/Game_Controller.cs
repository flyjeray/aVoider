using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Game_Controller : MonoBehaviour
{
    [Header("System Components")]
    public Game_DataContainer gameData;
    [SerializeField] private Player_DataContainer playerData;
    [SerializeField] private PlayerPrefs_Controller PlayerPrefsController;

    [Header("UI Components")]
    [SerializeField] private TextMeshProUGUI bestScoreText;
    [SerializeField] private TextMeshProUGUI scoreText;
    [SerializeField] private Button restartButton;
    [SerializeField] private TextMeshProUGUI hpText;
    [SerializeField] private Button startButton;

    [Header("Game Components")]
    [SerializeField] private GameObject player;
    [SerializeField] private GameObject bulletPackage;

    private void Awake()
    {
        PauseGame();

        bestScoreText.gameObject.SetActive(false);
        restartButton.gameObject.SetActive(false);
        hpText.gameObject.SetActive(false);

        UpdateHPText();
    }

    public void StartGame()
    {
        ResumeGame();

        hpText.gameObject.SetActive(true);
        startButton.gameObject.SetActive(false);
    }

    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        Time.timeScale = 1;
    }

    public void UpdateHPText()
    {
        hpText.text = "HP: " + (playerData.hp / 2);
    }

    public void PauseGame()
    {
        Time.timeScale = 0;
        gameData.isGameOn = false;
    }

    public void EndGame()
    {
        PauseGame();

        foreach (Transform child in bulletPackage.transform)
        {
            Destroy(child.gameObject);
        }
        Destroy(player);

        bool isScoreBeaten = PlayerPrefsController.CheckScoreBeat(gameData.playerScore);
        string bestScoreString;

        if (isScoreBeaten)
        {
            PlayerPrefsController.SetBestScore(gameData.playerScore);
            bestScoreString = "New Best!";
        }
        else
        {
            bestScoreString = "Your best: " + PlayerPrefsController.GetBestScore();
        }

        bestScoreText.text = bestScoreString;

        bestScoreText.gameObject.SetActive(true);
        restartButton.gameObject.SetActive(true);

        hpText.gameObject.SetActive(false);
    }

    public void ResumeGame()
    {
        Time.timeScale = 1;
        gameData.isGameOn = true;
    }    

    public void UpdateScoreText()
    {
        scoreText.text = gameData.playerScore.ToString();
    }
}
