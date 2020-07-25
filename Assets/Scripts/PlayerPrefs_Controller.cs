using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerPrefs_Controller : MonoBehaviour
{
    [SerializeField] private float BestScore;
    [SerializeField] private int Coins;
    [SerializeField] private string SettedSkin;
    
    // Best Score - float
    // Coins - int
    // Item buy Status - int
    // Best score functions
    
    private void Awake()
    {
        if (BestScore != 0) SetBestScore(BestScore);
        if (Coins != 0) UpdateCoins(Coins);
        if (GetSkinName() != null || !PlayerPrefs.HasKey("Active Skin")) SetSkin("WhiteMaterial");
    }

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

        // Coins functions
    
    public void UpdateCoins(int earnedCoins)
    {
        PlayerPrefs.SetInt("Coins", PlayerPrefs.GetInt("Coins") + earnedCoins);
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

        // Shop functions
    
    public int CheckIsItemBought(string itemName)
    {
        return PlayerPrefs.GetInt(itemName);
    }

    public void SetItemBought(string itemName)
    {
        PlayerPrefs.SetInt(itemName, 1);
    }

        // Skin functions
    
    public void SetSkin(string itemName)
    {
        PlayerPrefs.SetString("Active Skin", itemName);
    }

    public string GetSkinName()
    {
        return PlayerPrefs.GetString("Active Skin");
    }
}
