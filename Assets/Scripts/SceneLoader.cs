using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    private int STARTING_SCENE_INDEX = 0;
    public void LoadNextScene()
    {
        int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(currentSceneIndex + 1);
    }

    public void LoadStartingScene()
    {
        SceneManager.LoadScene(STARTING_SCENE_INDEX);
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
