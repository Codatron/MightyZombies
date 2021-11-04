using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LoadScene : MonoBehaviour
{
    public void MenuScene()
    {
        SceneManager.LoadScene("SceneMenu");
    }

    public void StartGame()
    {
        SceneManager.LoadScene("Level1");
    }

    public void HighScore()
    {
        SceneManager.LoadScene("SceneHighScore");
    }
}
