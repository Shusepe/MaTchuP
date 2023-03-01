    using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject pauseMenu;
    public GameObject gameplayButtons;
    public GameObject pauseButtons;
    public GameObject ordersPanel;

    public void pauseButton() 
    {
        pauseMenu.SetActive(true);
        gameplayButtons.SetActive(false);
        pauseButtons.SetActive(false);
        ordersPanel.SetActive(false);
        Time.timeScale = 0;
    }

    public void playButton() 
    {
        pauseMenu.SetActive(false);
        gameplayButtons.SetActive(true);
        pauseButtons.SetActive(true);
        ordersPanel.SetActive(true);
        Time.timeScale = 1;
    }

    public void exit() 
    {
        Application.Quit();
        Debug.Log("Saliste del juego...");
    }
}
