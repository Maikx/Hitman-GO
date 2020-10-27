using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Waypoint : MonoBehaviour
{
    public bool denyRight;
    public bool denyLeft;
    public bool denyForward;
    public bool denyBackward;
    public bool isFinish;
    public bool moveCamera;
    private PlayerController pC;


    void Start()
    {
        pC = GameObject.Find("Player").GetComponent<PlayerController>();
    }

    //If player in on the waypoint run these
    void PlayerCheck()
    {
        if (denyRight == true) pC.canMoveRight = false;
        if (denyLeft == true) pC.canMoveLeft = false;
        if (denyForward == true) pC.canMoveForward = false;
        if (denyBackward == true) pC.canMoveBackward = false;
        if (isFinish == true) Debug.Log("LevelFinish"); //This will be used to deactivate objects and make the ui pop up..
        if (moveCamera == true) Debug.Log("CameraMoved"); //This will be used to change the position of the camera..
    }

    //This checks if the player is on top of the waypoint;
    void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            PlayerCheck();
        }
    }
}
