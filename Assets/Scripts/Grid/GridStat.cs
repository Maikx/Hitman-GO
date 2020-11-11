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
    public GameObject Tile1_1;
    public GameObject Tile2_1;
    public GameObject Tile3_1;
    public GameObject Tile4_1;
    public GameObject Tile5_1;
    public GameObject Tile3_2;
    public GameObject Tile6_mini_2;
    public GameObject Tile6_2;
    public GameObject Tile7_2;
    public GameObject Tile8_mini_2;
    public GameObject Tile8_2;
    public GameObject Tile9_2;
    public GameObject Tile10_2;
    public GameObject Tile11_2;
    public GameObject Tile12_2;
    public GameObject Tile1_3;
    public GameObject Tile2_3;
    public GameObject Tile8_3;
    public GameObject Tile11_3;
    public GameObject Tile12_3;
    public GameObject Tile1_4;
    public GameObject Tile2_4;
    public GameObject Tile1_5;
    public GameObject Tile2_5;
    public GameObject Tile6_5;
    public GameObject Tile7_5;
    public GameObject Tile13_5;
    public GameObject Tile14_5;
    public GameObject Tile15_5;
    public GameObject Tile23_5;
    private GameManager gm;

    void Start()
    {
        pC = GameObject.Find("Player").GetComponent<PlayerController>();
        gm = GameObject.Find("GameManager").GetComponent<GameManager>();

        //This sets Tiles model and walkable by level..

        #region Level_1
        if (gm.level_1 == true)
        {
            if (x == 1 && y == 1 || x == 1 && y == 2 || x == 1 && y == 3)
            {
                waypoint.SetActive(true);
                gameObject.layer = 9;

                if (x == 1 && y == 1)
                {
                    Tile4_1.SetActive(true);
                    transform.eulerAngles = new Vector3(transform.eulerAngles.x, transform.eulerAngles.y - 90, transform.eulerAngles.z);
                }

                if (x == 1 && y == 2 || x == 1 && y == 3)
                {
                    Tile2_1.SetActive(true);
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
                    Tile5_1.SetActive(true);
                    transform.eulerAngles = new Vector3(transform.eulerAngles.x, transform.eulerAngles.y - 90, transform.eulerAngles.z);
                }
                if (x == 0 && y == 1 || x == 2 && y == 1)
                {
                    Tile3_1.SetActive(true);
                    transform.eulerAngles = new Vector3(transform.eulerAngles.x, transform.eulerAngles.y - 90, transform.eulerAngles.z);
                }
                if (x == 0 && y == 2 || x == 0 && y == 3 || x == 2 && y == 2 || x == 2 && y == 3)
                {
                    Tile1_1.SetActive(true);
                }


            }
        }
        #endregion

        #region Level_2
        if (gm.level_2 == true)
        {
            if (x == 0 && y == 0 || x == 1 && y == 0 || x == 2 && y == 0 || x == 2 && y == 1 || x == 2 && y == 2 || x == 2 && y == 3)
            {
                waypoint.SetActive(true);
                gameObject.layer = 9;
                if (x == 0 && y == 0 || x == 1 && y == 0 || x == 2 && y == 1 || x == 2 && y == 2 || x == 2 && y == 3)
                {
                    Tile6_mini_2.SetActive(true);
                    if (x == 2 && y == 1 || x == 2 && y == 2 || x == 2 && y == 3) transform.eulerAngles = new Vector3(transform.eulerAngles.x, transform.eulerAngles.y + 270, transform.eulerAngles.z);
                    if (x == 0 && y == 0) gameObject.tag = "Finish";
                }
                if (x == 2 && y == 0)
                {
                    Tile7_2.SetActive(true);
                    transform.eulerAngles = new Vector3(transform.eulerAngles.x, transform.eulerAngles.y - 90, transform.eulerAngles.z);
                }
            }
            else
            {
                if (x == 0 && y == 1 || x == 1 && y == 2 || x == 1 && y == 3)
                {
                    Tile8_2.SetActive(true);
                    if (x == 1 && y == 2 || x == 1 && y == 3) transform.eulerAngles = new Vector3(transform.eulerAngles.x, transform.eulerAngles.y - 90, transform.eulerAngles.z);
                }

                if (x == 0 && y == 2)
                {
                    Tile10_2.SetActive(true);
                    transform.eulerAngles = new Vector3(transform.eulerAngles.x, transform.eulerAngles.y - 90, transform.eulerAngles.z);
                }

                if (x == 0 && y == 3)
                {
                    Tile3_2.SetActive(true);
                    transform.eulerAngles = new Vector3(transform.eulerAngles.x, transform.eulerAngles.y + 270, transform.eulerAngles.z);
                }
                if (x == 1 && y == 1)
                {
                    Tile9_2.SetActive(true);
                    transform.eulerAngles = new Vector3(transform.eulerAngles.x, transform.eulerAngles.y + 270, transform.eulerAngles.z);
                }
            }
        }
        #endregion

        #region Level_3
        if (gm.level_3 == true)
        {
            if (x == 0 && y == 1 || x == 1 && y == 0 || x == 1 && y == 1 || x == 1 && y == 2 || x == 1 && y == 3 || x == 2 && y == 2 || x == 2 && y == 1 || x == 2 && y == 0)
            {
                waypoint.SetActive(true);
                gameObject.layer = 9;

                if (x == 1 && y == 0 || x == 1 && y == 2 || x == 1 && y == 3 || x == 2 && y == 0) Tile1_3.SetActive(true);

                if (x == 0 && y == 1 || x == 1 && y == 1 || x == 2 && y == 1)
                {
                    Tile2_3.SetActive(true);
                    if (x == 0 && y == 1)
                    {
                        gameObject.tag = "Finish";
                    }
                }

                if (x == 2 && y == 2)
                {
                    Tile11_3.SetActive(true);
                    transform.eulerAngles = new Vector3(transform.eulerAngles.x, transform.eulerAngles.y - 90, transform.eulerAngles.z);
                }
            }
            else
            {
                if (x == 0 && y == 0 || x == 0 && y == 2 || x == 0 && y == 3)
                {
                    Tile8_3.SetActive(true);
                    transform.eulerAngles = new Vector3(transform.eulerAngles.x, transform.eulerAngles.y - 90, transform.eulerAngles.z);
                }
                if (x == 2 && y == 3)
                {
                    Tile12_3.SetActive(true);
                    transform.eulerAngles = new Vector3(transform.eulerAngles.x, transform.eulerAngles.y + 270, transform.eulerAngles.z);
                }
            }
        }
        #endregion

        #region Level_4
        if (gm.level_4 == true)
        {
            if (x == 0 && y == 0 || x == 0 && y == 1 || x == 0 && y == 2 || x == 0 && y == 3 || x == 1 && y == 0 || x == 1 && y == 1 || x == 1 && y == 2 || x == 1 && y == 3 || x == 1 && y == 4 || x == 2 && y == 0 || x == 2 && y == 1 || x == 2 && y == 2 || x == 2 && y == 3 || x == 2 && y == 4 || x == 3 && y == 0 || x == 3 && y == 1 || x == 3 && y == 2 || x == 3 && y == 3)
            {
                waypoint.SetActive(true);
                gameObject.layer = 9;

                if (x == 0 && y == 0 || x == 0 && y == 1 || x == 0 && y == 2 || x == 0 && y == 3 || x == 1 && y == 0 || x == 1 && y == 1 || x == 1 && y == 2 || x == 1 && y == 3 || x == 1 && y == 4 || x == 3 && y == 0 || x == 3 && y == 1 || x == 3 && y == 2 || x == 3 && y == 3)
                {
                    Tile1_4.SetActive(true);
                    if (x == 0 && y == 2) denyBackward = true;
                    if (x == 1 && y == 2) denyForward = true;
                    if (x == 1 && y == 3) denyLeft = true;
                    if (x == 1 && y == 2) denyRight = true;
                    if (x == 3 && y == 2) denyForward = true;
                }

                if (x == 2 && y == 0 || x == 2 && y == 1 || x == 2 && y == 2 || x == 2 && y == 3 || x == 2 && y == 4)
                {
                    Tile2_4.SetActive(true);
                    transform.eulerAngles = new Vector3(transform.eulerAngles.x, transform.eulerAngles.y - 90, transform.eulerAngles.z);
                    if (x == 2 && y == 3) denyRight = true;
                    if (x == 2 && y == 4) denyLeft = true;
                    if (x == 2 && y == 2) denyBackward = true;
                }

                    if (x == 2 && y == 4)
                {
                    gameObject.tag = "Finish";
                }
            }
            else
            {
                if (x == 0 && y == 4 || x == 3 && y == 4) Tile1_4.SetActive(true);
            }

        }
        #endregion

        #region Level_5
        if (gm.level_5 == true)
        {
            if (x == 0 && y == 1 || x == 1 && y == 1 || x == 1 && y == 2 || x == 1 && y == 3 || x == 2 && y == 0 || x == 2 && y == 1 || x == 2 && y == 2 || x == 2 && y == 3 || x == 3 && y == 0 || x == 3 && y == 1 || x == 3 && y == 2 || x == 3 && y == 3)
            {
                waypoint.SetActive(true);
                gameObject.layer = 9;

                if (x == 0 && y == 1 || x == 1 && y == 3 || x == 2 && y == 3 || x == 3 && y == 3)
                {
                    Tile6_5.SetActive(true);
                    if (x == 0 && y == 1) gameObject.tag = "Finish";
                }

                if (x == 1 && y == 2 || x == 2 && y == 0 || x == 2 && y == 1 || x == 2 && y == 2 || x == 3 && y == 2)
                {
                    Tile1_5.SetActive(true);
                }

                if (x == 3 && y == 0)
                {
                    Tile2_5.SetActive(true);
                }

                if (x == 1 && y == 1)
                {
                    Tile7_5.SetActive(true);
                }

                if (x == 3 && y == 1)
                {
                    Tile23_5.SetActive(true);
                }

            }
            else
            {
                if (x == 0 && y == 0 || x == 1 && y == 0)
                {
                    Tile1_5.SetActive(true);
                }

                if (x == 0 && y == 3 || x == 1 && y == 4 || x == 2 && y == 4 || x == 3 && y == 4)
                {
                    Tile13_5.SetActive(true);
                }

                if (x == 0 && y == 4)
                {
                    Tile14_5.SetActive(true);
                }

                if (x == 0 && y == 2)
                {
                    Tile15_5.SetActive(true);
                }
            }
        }
        #endregion
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

