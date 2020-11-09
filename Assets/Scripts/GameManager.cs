using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public bool menu;
    public bool level_1;
    public bool level_2;
    public bool level_3;
    public bool level_4;
    public bool level_5;
    public bool level_6;
    [SerializeField] private bool isPaused;
    //questi verrano cambiati con l'index della scena perchè occupano linee di script inutili..

    private PlayerController pC;
    public Vector3 playerStartingPosition; 
    
    void Awake()
    {
        if (level_1 == true) playerStartingPosition = new Vector3(4, 0, 4);
        if (level_2 == true) playerStartingPosition = new Vector3(8, 0, 12);
    }

    void Start()
    {
        pC = GameObject.Find("Player").GetComponent<PlayerController>();
    }

    private void Update()
    {
        CheckGameStatus();
    }

    void CheckGameStatus()
    {
        if (pC.playerIsCaught == true) Debug.Log("GameLost, reloade scene");

        if (pC.playerIsAtFinish == true) Debug.Log("GameWon, pop up ui");

        if (Input.GetKey(KeyCode.Escape))
        {
            isPaused = !isPaused;
        }
        
        if (isPaused)
        {
            Debug.Log("GamePause, pop up ui");
        }
        else
        {
            Debug.Log("GameResumed, back to game");
        }
        
    }
}

