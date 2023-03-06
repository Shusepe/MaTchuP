using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuInit : MonoBehaviour
{
    public void Play()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void BackToMenu() 
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
        Time.timeScale = 1;
    }
    
    //public void Credits() 
    //{
    //    SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
    //    Time.timeScale = 1;
    //}

    public void Exit()
    {
        Debug.Log("Saliste del Juego");
        Application.Quit();
    }
}
