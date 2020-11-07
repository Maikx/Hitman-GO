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
    public GameObject Tile1;
    public GameObject Tile2;
    public GameObject Tile3;
    public GameObject Tile4;
    public GameObject Tile5;
    public GameObject Tile6_mini;
    public GameObject Tile6;
    public GameObject Tile7;
    public GameObject Tile8_mini;
    public GameObject Tile8;
    public GameObject Tile9;
    public GameObject Tile10;
    public GameObject Tile11;
    public GameObject Tile12;
    private GameManager gm;

    void Start()
    {
        pC = GameObject.Find("Player").GetComponent<PlayerController>();
        gm = GameObject.Find("GameManager").GetComponent<GameManager>();

        //This sets Tiles model and walkable by level..
        if (gm.level_1 == true)
        {
            if (x == 1 && y == 1 || x == 1 && y == 2 || x == 1 && y == 3)
            {
                waypoint.SetActive(true);
                gameObject.layer = 9;
                
                if (x == 1 && y == 1)
                {
                    Tile4.SetActive(true);
                    transform.eulerAngles = new Vector3(transform.eulerAngles.x, transform.eulerAngles.y - 90, transform.eulerAngles.z);
                }

                if (x == 1 && y == 2 || x == 1 && y == 3)
                {
                    Tile2.SetActive(true);
                    transform.eulerAngles = new Vector3(transform.eulerAngles.x, transform.eulerAngles.y - 90, transform.eulerAngles.z);
                    if (x == 1 && y == 3)
                    {
                        gameObject.tag = "Finish";
                    }
                }
            }
            else
            {
                if (x == 0 && y == 0 || x == 1 && y == 0 || x == 2 && y == 0)
                { 
                  Tile5.SetActive(true);
                    transform.eulerAngles = new Vector3(transform.eulerAngles.x, transform.eulerAngles.y - 90, transform.eulerAngles.z); 
                }
                if (x == 0 && y == 1 || x == 2 && y == 1)
                {
                    Tile3.SetActive(true);
                    transform.eulerAngles = new Vector3(transform.eulerAngles.x, transform.eulerAngles.y - 90, transform.eulerAngles.z);
                }
                if (x == 0 && y == 2 || x == 0 && y == 3 || x == 2 && y == 2 || x == 2 && y == 3)
                {
                    Tile1.SetActive(true);
                }


            }
        }

        if (gm.level_2 == true)
        {
            if (x == 0 && y == 0 || x == 1 && y == 0 || x == 2 && y == 0 || x == 2 && y == 1 || x == 2 && y == 2 || x == 2 && y == 3)
            {
                waypoint.SetActive(true);
                gameObject.layer = 9;
                if (x == 0 && y == 0 || x == 1 && y == 0 || x == 2 && y == 1 || x == 2 && y == 2 || x == 2 && y == 3)
                {
                    Tile6_mini.SetActive(true);
                    if (x == 2 && y == 1 || x == 2 && y == 2 || x == 2 && y == 3) transform.eulerAngles = new Vector3(transform.eulerAngles.x, transform.eulerAngles.y + 270, transform.eulerAngles.z);
                    if (x == 0 && y == 0) gameObject.tag = "Finish";
                }
                if (x == 2 && y == 0)
                {
                    Tile7.SetActive(true);
                    transform.eulerAngles = new Vector3(transform.eulerAngles.x, transform.eulerAngles.y - 90, transform.eulerAngles.z);
                }
            }
            else
            {
                if (x == 0 && y == 1 || x == 1 && y == 2 || x == 1 && y == 3)
                {
                    Tile8.SetActive(true);
                    if (x == 1 && y == 2 || x == 1 && y == 3) transform.eulerAngles = new Vector3(transform.eulerAngles.x, transform.eulerAngles.y - 90, transform.eulerAngles.z);
                }

                if (x == 0 && y == 2)
                {
                    Tile10.SetActive(true);
                    transform.eulerAngles = new Vector3(transform.eulerAngles.x, transform.eulerAngles.y - 90, transform.eulerAngles.z);
                }

                if (x == 0 && y == 3)
                {
                    Tile3.SetActive(true);
                    transform.eulerAngles = new Vector3(transform.eulerAngles.x, transform.eulerAngles.y + 180, transform.eulerAngles.z);
                }
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

