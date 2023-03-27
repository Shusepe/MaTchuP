using UnityEngine;
using UnityEngine.SceneManagement;

public class MusicMenu : MonoBehaviour
{
    private static MusicMenu instance = null;

    void Awake()
    {
        if (instance == null)
        {
            instance = this;
            SceneManager.sceneLoaded += OnSceneLoad;
        }
        else
        {
            Destroy(gameObject);
        }

        DontDestroyOnLoad(gameObject);
    }

    private void OnSceneLoad(Scene sceneLoaded, LoadSceneMode loadMode)
    {
        if (sceneLoaded.name == "Game")
        {
            SceneManager.sceneLoaded -= OnSceneLoad;

            Destroy(gameObject);
        }
    }
}
