using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PassMenu : MonoBehaviour
{
    public static bool gameIsPaused=false;
   public GameObject pauseMenuUI;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            if (gameIsPaused)
                Resume();
        }
        else
        {
            Paused();
        }
    }

    public void Resume()
    {
        pauseMenuUI.SetActive(true);
       //Time.timeScale = 1f;
        gameIsPaused = false;
        //GameControl.instance.gameIsPaused = false;
        GameControl.instance.gameover = false;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex );
        Debug.Log(" Resume...");
    }

    public void Paused()
    {
      //  pauseMenuUI.SetActive(true);
        // Time.timeScale = 0f;
       // gameIsPaused = true;
       // GameControl.instance.gameIsPaused = true;
        //GameControl.instance.gameover = true;
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
