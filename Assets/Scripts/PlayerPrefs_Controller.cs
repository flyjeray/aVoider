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
}
