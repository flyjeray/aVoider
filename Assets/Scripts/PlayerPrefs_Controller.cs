using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerPrefs_Controller : MonoBehaviour
{
    // Best Score - float
    // Coins - int
    
    public void SetBestScore(float newBest)
    {
        PlayerPrefs.SetFloat("Best Score", newBest);
    }

    public bool CheckScoreBeat(float score)
    {
        return score > GetBestScore();
    }

    public float GetBestScore()
    {
        return PlayerPrefs.GetFloat("Best Score");
    }

    public void UpdateCoins(float earnedCoins)
    {
        PlayerPrefs.SetInt("Coins", (int)(PlayerPrefs.GetFloat("Coins") + earnedCoins));
    }
    
    public float GetCoins()
    {
        return PlayerPrefs.GetInt("Coins");
    }

    public void FullStatsRecover()
    {
        PlayerPrefs.SetInt("Coins", 0);
        PlayerPrefs.SetFloat("Best Score", 0);
    }
}
