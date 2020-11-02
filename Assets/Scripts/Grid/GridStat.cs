using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GridStat : MonoBehaviour
{
    public int visited = -1;
    public int x = 0;
    public int y = 0;
    public bool denyRight;
    public bool denyLeft;
    public bool denyForward;
    public bool denyBackward;
    public bool isFinish;
    public bool moveCamera;
    private PlayerController pC;
    public GameObject waypoint;
    private GameManager gm;

    void Start()
    {
        pC = GameObject.Find("Player").GetComponent<PlayerController>();
        gm = GameObject.Find("GameManager").GetComponent<GameManager>();

        if (gm.level_1 == true)
        {
            if (x == 1 && y == 1 || x == 1 && y == 2 || x == 1 && y == 3)
            {
                waypoint.SetActive(true);
                gameObject.layer = 9;
            }
            else
            {
                waypoint.SetActive(false);
            }
        }

        if (gm.level_2 == true)
        {
            if (x == 0 && y == 0 || x == 1 && y == 0 || x == 2 && y == 0 || x == 2 && y == 1 || x == 2 && y == 2 || x == 2 && y == 3)
            {
                waypoint.SetActive(true);
                gameObject.layer = 9;
            }
            else
            {
                waypoint.SetActive(false);
            }
        }

    }

    void PlayerCheck()
    {
        if (denyRight == true) pC.canMoveRight = false;
        if (denyLeft == true) pC.canMoveLeft = false;
        if (denyForward == true) pC.canMoveForward = false;
        if (denyBackward == true) pC.canMoveBackward = false;
        if (isFinish == true) Debug.Log("LevelFinish"); //This will be used to deactivate objects and make the ui pop up..
        if (moveCamera == true) Debug.Log("CameraMoved"); //This will be used to change the position of the camera..
    }

    void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            PlayerCheck();
        }
    }
}

