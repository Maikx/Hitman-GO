﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

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
}
