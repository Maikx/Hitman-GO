using System.Collections;
using System.Collections.Generic;
using System.Transactions;
using UnityEditor;
using UnityEngine;
using UnityEngine.AI;

public class PlayerController : MonoBehaviour
{
    public float speed;
    public bool isMoving;
    private Right right;
    private Left left;
    private Forward forward;
    private Backward backward;

    public bool canMoveRight;
    public bool canMoveLeft;
    public bool canMoveForward;
    public bool canMoveBackward;
    public bool playerIsCaught;
    public bool playerIsAtFinish;

    public GameObject player;
    public GameObject playerCollider;
    public Vector3 playerpos;
    public Transform target = null;
    private GameManager gm;


    void Start()
    {
        right = GameObject.Find("Right").GetComponent<Right>();
        left = GameObject.Find("Left").GetComponent<Left>();
        forward = GameObject.Find("Forward").GetComponent<Forward>();
        backward = GameObject.Find("Backward").GetComponent<Backward>();
        gm = GameObject.Find("GameManager").GetComponent<GameManager>();
        transform.position = gm.playerStartingPosition;
        isMoving = false;
        canMoveRight = false;
        playerIsCaught = false;
    }

    private void Update()
    {
        Movement();
        DestroyPlayer();
        PlayerCaught();
    }

    private void Movement()
    {
        playerpos = transform.position;

        //This is not implemented yet...
        if (isMoving == true)
        {
            canMoveRight = false;
            canMoveLeft = false;
            canMoveForward = false;
            canMoveBackward = false;
        }

        //Target is where the player will move to, it changes everytime in the other scripts (Backward, Forward, Left, Right)
        if (target != null)
        {
            float step = speed * Time.deltaTime;
            transform.position = Vector3.MoveTowards(transform.position, target.position, step);
        }
    }

    private void PlayerCaught()
    {
        if(playerIsCaught == true)Destroy(player);
    }

    private void DestroyPlayer()
    {
        if (playerCollider == null)
        {
            playerIsCaught = true;
        }
    }
}



