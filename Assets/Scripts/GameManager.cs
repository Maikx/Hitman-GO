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
    //questi verrano cambiati con l'index della scena perchè occupano linee di script inutili..

    public Vector3 playerStartingPosition; 
    
    void Awake()
    {
        if (level_1 == true) playerStartingPosition = new Vector3(4, 1.82f, 4);
        if (level_2 == true) playerStartingPosition = new Vector3(8, 0, 12);
    }
}

