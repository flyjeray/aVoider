using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu_Switch : MonoBehaviour
{
    public void BackToMainMenu()
    {
        SceneManager.LoadScene("Main Menu");
    }

    public void StartGame()
    {
        SceneManager.LoadScene("Game");
    }

    public void LoadShop()
    {
        SceneManager.LoadScene("Shop");
    }

    public void CustomColor()
    {
        SceneManager.LoadScene("Custom Color");
    }
}
