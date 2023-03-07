using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
    public AudioSource audioSource;

    private void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    public void LoadScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);

        audioSource.Play(); 
    }

    public void Exit()
    {
        Debug.Log("Saliste del Juego");
        Application.Quit();
    }
}
