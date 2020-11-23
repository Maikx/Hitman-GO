using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LevelSelection : MonoBehaviour
{
    public Button[] LevelX;
    public bool[] LevelXCom;
    // Start is called before the first frame update
    void Start()
    {
        CheckInts();
    }

    // Update is called once per frame
    void Update()
    {
        if (LevelXCom[0] == true)
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

    public void CheckInts()
    {
        if(PersistentBools.CompLevel1==1)
        {
            LevelXCom[0] = true;
        }
        else
        {
            LevelXCom[0] = false;
        }
        if (PersistentBools.CompLevel2 == 1)
        {
            LevelXCom[1] = true;
        }
        else
        {
            LevelXCom[1] = false;
        }
        if (PersistentBools.CompLevel3 == 1)
        {
            LevelXCom[2] = true;
        }
        else
        {
            LevelXCom[2] = false;
        }
        if (PersistentBools.CompLevel4 == 1)
        {
            LevelXCom[3] = true;
        }
        else
        {
            LevelXCom[3] = false;
        }
        if (PersistentBools.CompLevel5 == 1)
        {
            LevelXCom[4] = true;
        }
        else
        {
            LevelXCom[4] = false;
        }
    }

    public void BackToMenu()
    {
        SceneManager.LoadScene(0);
    }

    #region Level Selection
    public void GoToLevel1()
    {
        SceneManager.LoadScene(2);
    }

    public void GoToLevel2()
    {
        SceneManager.LoadScene(3);
    }

    public void GoToLevel3()
    {
        SceneManager.LoadScene(4);
    }

    public void GoToLevel4()
    {
        SceneManager.LoadScene(5);
    }

    public void GoToLevel5()
    {
        SceneManager.LoadScene(6);
    }

    public void GoToLevel6()
    {
        SceneManager.LoadScene(7);
    }
    #endregion
}
