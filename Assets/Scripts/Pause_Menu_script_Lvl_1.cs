using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Pause_Menu_script_Lvl_2 : MonoBehaviour
{
    public static bool GameIsPaused = false;
    
    public GameObject PauseUI;
    // Update is called once per frame
  
    public void Resume()
    {
        PauseUI.SetActive(false);
        Time.timeScale = 1f;
        GameIsPaused = false;
    }

    public void Pause()
    {
        PauseUI.SetActive(true);
        Time.timeScale = 0;
        GameIsPaused = true;
    }

    public void LoadMenu()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("Menu");
    }
    public void Retry()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("Level 1");
    }
}
