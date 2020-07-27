using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerPrefs_Controller : MonoBehaviour
{    
    // Best Score - float
    // Coins - int
    // Item buy Status - int
    // Best score functions

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

        // Custom Color functions

    public float GetSavedColorValue(string colorType)
    {
        return PlayerPrefs.GetFloat(colorType);
    }

    public void SetSavedColorValue(string colorType, float colorValue)
    {
        PlayerPrefs.SetFloat(colorType, colorValue);
    }

    public Color GetSavedColor()
    {
        return new Color(GetSavedColorValue("Red"), GetSavedColorValue("Green"), GetSavedColorValue("Blue"), 255);
    }
}
