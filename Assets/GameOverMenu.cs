using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverMenu : MonoBehaviour
{

    public void PlayAgainButton()
    {
        SceneManager.LoadScene(0);
        Time.timeScale = 1;
    }
    public void QuitButton()
    {
        Application.Quit();
    }

}
