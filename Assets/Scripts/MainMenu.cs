﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenu : MonoBehaviour
{
    public Button[] LevelX;
    public bool[] LevelXCom;
    public GameObject LevelSelection;
    public GameObject Options;
    public GameObject Main;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(LevelXCom[0]==true)
        {
            LevelX[0].gameObject.SetActive(true);
        }
        else
        {
            LevelX[0].gameObject.SetActive(false);
        }

        if (LevelXCom[1] == true)
        {
            LevelX[1].gameObject.SetActive(true);
        }
        else
        {
            LevelX[1].gameObject.SetActive(false);
        }

        if (LevelXCom[2] == true)
        {
            LevelX[2].gameObject.SetActive(true);
        }
        else
        {
            LevelX[2].gameObject.SetActive(false);
        }

        if (LevelXCom[3] == true)
        {
            LevelX[3].gameObject.SetActive(true);
        }
        else
        {
            LevelX[3].gameObject.SetActive(false);
        }

        if (LevelXCom[4] == true)
        {
            LevelX[4].gameObject.SetActive(true);
        }
        else
        {
            LevelX[4].gameObject.SetActive(false);
        }
    }

    #region Level Selection
    public void GoToLevel1()
    {
        SceneManager.LoadScene(1);
    }

    public void GoToLevel2()
    {
        SceneManager.LoadScene(2);
    }

    public void GoToLevel3()
    {
        SceneManager.LoadScene(3);
    }

    public void GoToLevel4()
    {
        SceneManager.LoadScene(4);
    }

    public void GoToLevel5()
    {
        SceneManager.LoadScene(5);
    }

    public void GoToLevel6()
    {
        SceneManager.LoadScene(6);
    }
    #endregion

    public void GoToOptions()
    {
        Main.gameObject.SetActive(false);
        Options.gameObject.SetActive(true);
    }
    public void BackToMenu()
    {
        Main.gameObject.SetActive(true);
        Options.gameObject.SetActive(false);
    }
    public void GoToLevelSelection()
    {
        Main.gameObject.SetActive(false);
        LevelSelection.gameObject.SetActive(true);
    }
}
