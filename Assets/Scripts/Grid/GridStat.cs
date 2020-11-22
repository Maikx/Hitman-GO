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
    public GameObject rock;
    public GameObject[] currentTile;
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
                    currentTile[3].SetActive(true);
                    transform.eulerAngles = new Vector3(transform.eulerAngles.x, transform.eulerAngles.y - 90, transform.eulerAngles.z);
                }

                if (x == 1 && y == 2 || x == 1 && y == 3)
                {
                    currentTile[1].SetActive(true);
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
                    currentTile[4].SetActive(true);
                    transform.eulerAngles = new Vector3(transform.eulerAngles.x, transform.eulerAngles.y - 90, transform.eulerAngles.z);
                }
                if (x == 0 && y == 1 || x == 2 && y == 1)
                {
                    currentTile[2].SetActive(true);
                    transform.eulerAngles = new Vector3(transform.eulerAngles.x, transform.eulerAngles.y - 90, transform.eulerAngles.z);
                }
                if (x == 0 && y == 2 || x == 0 && y == 3 || x == 2 && y == 2 || x == 2 && y == 3)
                {
                    currentTile[0].SetActive(true);
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
                    currentTile[6].SetActive(true);
                    if (x == 2 && y == 1 || x == 2 && y == 2 || x == 2 && y == 3) transform.eulerAngles = new Vector3(transform.eulerAngles.x, transform.eulerAngles.y + 270, transform.eulerAngles.z);
                    if (x == 0 && y == 0) gameObject.tag = "Finish";
                }
                if (x == 2 && y == 0)
                {
                    currentTile[8].SetActive(true);
                    transform.eulerAngles = new Vector3(transform.eulerAngles.x, transform.eulerAngles.y - 90, transform.eulerAngles.z);
                }
            }
            else
            {
                if (x == 0 && y == 1 || x == 1 && y == 2 || x == 1 && y == 3)
                {
                    currentTile[10].SetActive(true);
                    if (x == 1 && y == 2 || x == 1 && y == 3) transform.eulerAngles = new Vector3(transform.eulerAngles.x, transform.eulerAngles.y - 90, transform.eulerAngles.z);
                }

                if (x == 0 && y == 2)
                {
                    currentTile[12].SetActive(true);
                    transform.eulerAngles = new Vector3(transform.eulerAngles.x, transform.eulerAngles.y - 90, transform.eulerAngles.z);
                }

                if (x == 0 && y == 3)
                {
                    currentTile[5].SetActive(true);
                    transform.eulerAngles = new Vector3(transform.eulerAngles.x, transform.eulerAngles.y + 270, transform.eulerAngles.z);
                }
                if (x == 1 && y == 1)
                {
                    currentTile[11].SetActive(true);
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

                if (x == 1 && y == 0 || x == 1 && y == 2 || x == 1 && y == 3 || x == 2 && y == 0) currentTile[15].SetActive(true);

                if (x == 0 && y == 1 || x == 1 && y == 1 || x == 2 && y == 1)
                {
                    currentTile[16].SetActive(true);
                    if (x == 0 && y == 1)
                    {
                        gameObject.tag = "Finish";
                    }
                }

                if (x == 2 && y == 2)
                {
                    currentTile[18].SetActive(true);
                    transform.eulerAngles = new Vector3(transform.eulerAngles.x, transform.eulerAngles.y - 90, transform.eulerAngles.z);
                }
            }
            else
            {
                if (x == 0 && y == 0 || x == 0 && y == 2 || x == 0 && y == 3)
                {
                    currentTile[17].SetActive(true);
                    transform.eulerAngles = new Vector3(transform.eulerAngles.x, transform.eulerAngles.y - 90, transform.eulerAngles.z);
                }
                if (x == 2 && y == 3)
                {
                    currentTile[19].SetActive(true);
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
                    currentTile[20].SetActive(true);
                    if (x == 0 && y == 2) denyBackward = true;
                    if (x == 1 && y == 2) denyForward = true;
                    if (x == 1 && y == 3) denyLeft = true;
                    if (x == 1 && y == 2) denyRight = true;
                    if (x == 3 && y == 2) denyForward = true;
                }

                if (x == 2 && y == 0 || x == 2 && y == 1 || x == 2 && y == 2 || x == 2 && y == 3 || x == 2 && y == 4)
                {
                    currentTile[21].SetActive(true);
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
                if (x == 0 && y == 4 || x == 3 && y == 4) currentTile[20].SetActive(true);
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
                    if (x == 1 && y == 3)
                    {
                        currentTile[31].SetActive(true);
                        transform.eulerAngles = new Vector3(transform.eulerAngles.x, transform.eulerAngles.y - 90, transform.eulerAngles.z);
                    }
                    else
                    {
                        currentTile[24].SetActive(true);
                        transform.eulerAngles = new Vector3(transform.eulerAngles.x, transform.eulerAngles.y - 90, transform.eulerAngles.z);
                        if (x == 0 && y == 1) gameObject.tag = "Finish";
                    }
                }

                if (x == 2 && y == 0 || x == 2 && y == 1 || x == 2 && y == 2 || x == 3 && y == 2)
                {
                    currentTile[22].SetActive(true);
                    if (x == 2 && y == 1)
                    {
                        denyForward = true;
                        denyRight = true;
                        denyBackward = true;
                        gameObject.tag = "Rock";
                        rock.SetActive(true);
                    }

                    if (x == 2 && y == 2)
                    {
                        denyLeft = true;
                        denyForward = true;
                    }
                }

                if (x == 1 && y == 2)
                {
                    currentTile[24].SetActive(true);
                    transform.eulerAngles = new Vector3(transform.eulerAngles.x, transform.eulerAngles.y + 180, transform.eulerAngles.z);
                    denyBackward = true;
                }

                if (x == 3 && y == 0)
                {
                    currentTile[23].SetActive(true);
                    transform.eulerAngles = new Vector3(transform.eulerAngles.x, transform.eulerAngles.y + 90, transform.eulerAngles.z);
                }

                if (x == 1 && y == 1)
                {
                    currentTile[25].SetActive(true);
                    transform.eulerAngles = new Vector3(transform.eulerAngles.x, transform.eulerAngles.y - 90, transform.eulerAngles.z);
                    denyBackward = true;
                }

                if (x == 3 && y == 1)
                {
                    currentTile[30].SetActive(true);
                    transform.eulerAngles = new Vector3(transform.eulerAngles.x, transform.eulerAngles.y + 270, transform.eulerAngles.z);
                    denyForward = true;
                }

            }
            else
            {
                if (x == 0 && y == 0 || x == 1 && y == 0)
                {
                    currentTile[22].SetActive(true);
                }

                if (x == 0 && y == 3 || x == 1 && y == 4 || x == 2 && y == 4 || x == 3 && y == 4)
                {
                    if (x == 0 && y == 3)
                    {
                        currentTile[27].SetActive(true);
                    }
                    else
                    {
                        transform.eulerAngles = new Vector3(transform.eulerAngles.x, transform.eulerAngles.y + 90, transform.eulerAngles.z);
                        currentTile[27].SetActive(true);
                    }
                }

                if (x == 0 && y == 4)
                {
                    currentTile[28].SetActive(true);
                    transform.eulerAngles = new Vector3(transform.eulerAngles.x, transform.eulerAngles.y + 90, transform.eulerAngles.z);
                }

                if (x == 0 && y == 2)
                {
                    currentTile[29].SetActive(true);
                    transform.eulerAngles = new Vector3(transform.eulerAngles.x, transform.eulerAngles.y + 90, transform.eulerAngles.z);
                }
            }
        }
        #endregion

        #region Level_6
        if (gm.level_6 == true)
        {
            if (x == 0 && y == 1 || x == 0 && y == 3 || x == 1 && y == 0 || x == 1 && y == 1 || x == 1 && y == 2 || x == 1 && y == 3 || x == 2 && y == 0 || x == 2 && y == 1 || x == 2 && y == 2 || x == 2 && y == 3 || x == 3 && y == 0 || x == 3 && y == 1 || x == 3 && y == 2 || x == 3 && y == 3)
            {
                waypoint.SetActive(true);
                gameObject.layer = 9;

                if (x == 2 && y == 0 || x == 3 && y == 0 || x == 2 && y == 1 || x == 3 && y == 1)
                {
                    currentTile[33].SetActive(true);
                    if (x == 2 && y == 1)
                    {
                        denyForward = true;
                        denyBackward = true;
                    }
                    if (x == 3 && y == 1) denyForward = true;
                }

                if (x == 2 && y == 2 || x == 3 && y == 2)
                {
                    currentTile[34].SetActive(true);
                    transform.eulerAngles = new Vector3(transform.eulerAngles.x, transform.eulerAngles.y + 270, transform.eulerAngles.z);
                    if (x == 2 && y == 2)
                    {
                        denyRight = true;
                        denyForward = true;
                    }
                    if (x == 3 && y == 2) denyRight = true;
                }

                if (x == 1 && y == 0 || x == 0 && y == 1 || x == 1 && y == 1)
                {
                    currentTile[36].SetActive(true);
                    if (x == 1 && y == 1) denyBackward = true;
                }

                if (x == 1 && y == 2)
                {
                    currentTile[37].SetActive(true);
                    transform.eulerAngles = new Vector3(transform.eulerAngles.x, transform.eulerAngles.y + 90, transform.eulerAngles.z);
                    denyBackward = true;
                }

                if (x == 3 && y == 3)
                {
                    currentTile[38].SetActive(true);
                    denyLeft = true;
                }

                if (x == 2 && y == 3)
                {
                    currentTile[39].SetActive(true);
                    denyLeft = true;
                }

                if (x == 1 && y == 3)
                {
                    currentTile[40].SetActive(true);
                }

                if (x == 0 && y == 3)
                {
                    currentTile[41].SetActive(true);
                    gameObject.tag = "Finish";
                }

            }
            else
            {
                if (x == 0 && y == 0)
                {
                    currentTile[35].SetActive(true);
                }

                if (x == 0 && y == 2)
                {
                    transform.eulerAngles = new Vector3(transform.eulerAngles.x, transform.eulerAngles.y + 90, transform.eulerAngles.z);
                    currentTile[37].SetActive(true);
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
            if (x == 2 && y == 1) rock.SetActive(false);

        }
    }
}

