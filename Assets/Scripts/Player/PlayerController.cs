using System.Collections;
using System.Collections.Generic;
using System.Transactions;
using UnityEditor;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.EventSystems;

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
        MouseClick();
        Movement();
        DestroyPlayer();
        PlayerCaught();
    }

    public void MouseClick()
    {
        if (Input.GetMouseButtonDown(0) && !EventSystem.current.IsPointerOverGameObject())
        {
            RaycastHit hit;
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(ray, out hit))
            {
                if(hit.collider.tag == "Left" && canMoveLeft == true && isMoving == false)
                {
                    target = left.left;
                }

                if (hit.collider.tag == "Right" && canMoveRight == true && isMoving == false)
                {
                    target = right.right;
                }

                if (hit.collider.tag == "Forward" && canMoveForward == true && isMoving == false)
                {
                    target = forward.forward;
                }

                if (hit.collider.tag == "Backward" && canMoveBackward == true && isMoving == false)
                {
                    target = backward.backward;
                }
            }
        }
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



