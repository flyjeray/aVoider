using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerPrefs_Controller : MonoBehaviour
{
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
        PlayerPrefs.SetFloat("Coins", PlayerPrefs.GetFloat("Coins") + earnedCoins);
    }
    
    public float GetCoins()
    {
        return PlayerPrefs.GetFloat("Coins");
    }
}
