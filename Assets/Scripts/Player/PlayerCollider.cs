using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerCollider : MonoBehaviour
{
    private PlayerController pC;
    private Catch catchS;

    // Start is called before the first frame update
    void Start()
    {
        pC = GameObject.Find("Player").GetComponent<PlayerController>();

        if (GameObject.FindWithTag("Enemy") != null) catchS = GameObject.Find("Front").GetComponent<Catch>(); 
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.tag == "Finish")
        {
            pC.isMoving = true;
            pC.playerIsAtFinish = true;
            CheckScene();
        }
        if (collision.gameObject.tag == "Enemy" && catchS.isPlayer == false)
        {
            Destroy(collision.gameObject);
        }
        if(collision.gameObject.tag == "Rock")
        {
            pC.throwRock = true;
        }
    }
    //Based on the current scene name this will register the level as complete
    public void CheckScene()
    {
        Scene CurrentScene = SceneManager.GetActiveScene();
        string SceneName = CurrentScene.name;
        if (SceneName=="Level 1")
        {
            PersistentBools.CompLevel1 = 1;
            PlayerPrefs.SetInt("Level1Comp", 1);
        }                               
        else if (SceneName == "Level 2")
        {                               
            PersistentBools.CompLevel2 = 1;
            PlayerPrefs.SetInt("Level2Comp", 1);
        }                               
        else if (SceneName == "Level 3")
        {                               
            PersistentBools.CompLevel3 = 1;
            PlayerPrefs.SetInt("Level3Comp", 1);
        }                               
        else if (SceneName == "Level 4")
        {                                
            PersistentBools.CompLevel4 = 1;
            PlayerPrefs.SetInt("Level4Comp", 1);
        }                               
        else if (SceneName == "Level 5")
        {                                
            PersistentBools.CompLevel5 = 1;
            PlayerPrefs.SetInt("Level5Comp", 1);
        }
        else if (SceneName == "Level 6")
        {
            PersistentBools.CompLevel6 = 1;
            PlayerPrefs.SetInt("Level6Comp", 1);
        }
    }
}
