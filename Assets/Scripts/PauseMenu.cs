using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    public GameObject PauseMenuO;
    public GameObject CompStamp;
    [SerializeField] private bool isPaused;
    // Start is called before the first frame update
    void Start()
    {
        CheckScene();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (isPaused == false)
            {
                PauseGame();
            }
            else
            {
                ResumeGame();
            }
        }
    }

    public void PauseGame()
    {
        Time.timeScale = 0f;
        PauseMenuO.SetActive(true);
        isPaused = true;
    }
    public void ResumeGame()
    {
        Time.timeScale = 1f;
        PauseMenuO.SetActive(false);
        isPaused = false;
    }
    public void Reload()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    public void BackToSelection()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(1);
    }

    public void CheckScene()
    {
        Scene CurrentScene = SceneManager.GetActiveScene();
        string SceneName = CurrentScene.name;
        if (SceneName == "Level 1")
        {
            if(PersistentBools.CompLevel1==1)
            {
                CompStamp.SetActive(true);
            }
            else
            {
                CompStamp.SetActive(false);
            }
        }
        else if (SceneName == "Level 2")
        {
            if (PersistentBools.CompLevel2 == 1)
            {
                CompStamp.SetActive(true);
            }
            else
            {
                CompStamp.SetActive(false);
            }
        }
        else if (SceneName == "Level 3")
        {
            if (PersistentBools.CompLevel3 == 1)
            {
                CompStamp.SetActive(true);
            }
            else
            {
                CompStamp.SetActive(false);
            }
        }
        else if (SceneName == "Level 4")
        {
            if (PersistentBools.CompLevel4 == 1)
            {
                CompStamp.SetActive(true);
            }
            else
            {
                CompStamp.SetActive(false);
            }
        }
        else if (SceneName == "Level 5")
        {
            if (PersistentBools.CompLevel5 == 1)
            {
                CompStamp.SetActive(true);
            }
            else
            {
                CompStamp.SetActive(false);
            }
        }
        else if (SceneName == "Level 6")
        {
            if (PersistentBools.CompLevel6 == 1)
            {
                CompStamp.SetActive(true);
            }
            else
            {
                CompStamp.SetActive(false);
            }
        }
    }
}
