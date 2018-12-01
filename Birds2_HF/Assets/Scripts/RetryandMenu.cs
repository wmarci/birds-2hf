using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RetryandMenu : MonoBehaviour {

	

	private void Update () {

        if (Input.GetKeyDown(KeyCode.R))
        {

            SceneManager.LoadScene(SceneManager.GetActiveScene().name); //SceneManager.LoadScene("GameScene1");

        } 
        
        if(Input.GetKeyDown(KeyCode.M)) {

            SceneManager.LoadScene("MainMenu");

        }

	}
}
