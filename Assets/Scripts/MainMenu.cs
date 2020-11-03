using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenu : MonoBehaviour
{
    
    public GameObject LevelSelection;
    public GameObject Options;
    public GameObject Main;
    public GameObject Reset;
    public GameObject Credits;
    public bool Sound = true;
    public bool Music = true;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public void GoToOptions()
    {
        Main.gameObject.SetActive(false);
        Options.gameObject.SetActive(true);
    }
    public void GoToLevelSelection()
    {
        SceneManager.LoadScene(1);
    }
    #region Options
    public void BackToMenu()
    {
        Main.gameObject.SetActive(true);
        Options.gameObject.SetActive(false);
    }
    public void SoundBool()
    {
        if(Sound==true)
        {
            Sound = false;
        }
        else
        {
            Sound = true;
        }
    }
    public void MusicBool()
    {
        if(Music==true)
        {
            Music = false;
        }
        else
        {
            Music=true;
        }
    }
    public void GoToResetGame()
    {
        Options.gameObject.SetActive(false);
        Reset.gameObject.SetActive(true);
    }
    public void GoToCredits()
    {
        Options.gameObject.SetActive(false);
        Credits.gameObject.SetActive(true);
    }
    #endregion

    #region Reset
    public void ConfirmReset()
    {
        Debug.Log("Game Resetted");
    }
    public void NegateReset()
    {
        Reset.gameObject.SetActive(false);
        Options.gameObject.SetActive(true);
    }
    #endregion
    public void BackToOptions()
    {
        Credits.gameObject.SetActive(false);
        Options.gameObject.SetActive(true);
    }
}
