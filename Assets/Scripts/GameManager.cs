using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject pauseMenu;
    public GameObject gameplayButtons;
    public GameObject dispensers;
    public GameObject pauseButtons;
    public GameObject ordersPanel;

    public void pauseButton() 
    {
        pauseMenu.SetActive(true);
        gameplayButtons.SetActive(false);
        dispensers.SetActive(false);
        pauseButtons.SetActive(false);
        ordersPanel.SetActive(false);
        Time.timeScale = 0;

        ButtonsSound.instance.PlayButtonSound();
    }

    public void playButton() 
    {
        pauseMenu.SetActive(false);
        gameplayButtons.SetActive(true);
        dispensers.SetActive(true);
        pauseButtons.SetActive(true);
        ordersPanel.SetActive(true);
        Time.timeScale = 1;

        ButtonsSound.instance.PlayButtonSound();
    }
}
