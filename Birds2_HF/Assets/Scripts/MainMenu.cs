using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{


    public void PlayGame1()
    {
        SceneManager.LoadScene("GameScene1"); //SceneManager.GetActiveScene().buildIndex + 1
    }

    public void PlayGame2()
    {
        SceneManager.LoadScene("GameScene2"); //SceneManager.GetActiveScene().buildIndex + 1
    }

    public void PlayGame3()
    {
        SceneManager.LoadScene("GameScene3"); //SceneManager.GetActiveScene().buildIndex + 1
    }

    public void PlayGame4()
    {
        SceneManager.LoadScene("GameScene4"); //SceneManager.GetActiveScene().buildIndex + 1
    }

    public void QuitGame() {

        Debug.Log("Quit");
        Application.Quit();

    }


}

