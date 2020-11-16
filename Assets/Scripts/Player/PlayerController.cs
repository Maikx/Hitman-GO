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
    private MeshRenderer rightMR;
    private Left left;
    private MeshRenderer leftMR;
    private Forward forward;
    private MeshRenderer forwardMR;
    private Backward backward;
    private MeshRenderer backwardMR;

    public bool canMoveRight;
    public bool canMoveLeft;
    public bool canMoveForward;
    public bool canMoveBackward;
    public bool playerIsCaught;
    public bool playerIsAtFinish;
    public bool throwRock;

    public GameObject player;
    public GameObject playerCollider;
    public Vector3 playerpos;
    public Transform target = null;
    private GameManager gm;

    void Start()
    {
        right = GameObject.Find("Right").GetComponent<Right>();
        rightMR = GameObject.Find("Right").GetComponent<MeshRenderer>();
        left = GameObject.Find("Left").GetComponent<Left>();
        leftMR = GameObject.Find("Left").GetComponent<MeshRenderer>();
        forward = GameObject.Find("Forward").GetComponent<Forward>();
        forwardMR = GameObject.Find("Forward").GetComponent<MeshRenderer>();
        backward = GameObject.Find("Backward").GetComponent<Backward>();
        backwardMR = GameObject.Find("Backward").GetComponent<MeshRenderer>();
        gm = GameObject.Find("GameManager").GetComponent<GameManager>();
        transform.position = gm.playerStartingPosition;
        isMoving = false;
        canMoveRight = false;
        playerIsCaught = false;
    }

    private void Update()
    {
        InputSystem();
        Movement();
        DestroyPlayer();
        PlayerCaught();
        Rock();
    }

    public void InputSystem()
    {
        #region Mouse
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
        #endregion

        #region Touch
        if (Input.touchCount > 0 && Input.touches[0].phase == TouchPhase.Began)
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.touches[0].position);
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit))
            {
                if (hit.collider.tag == "Left" && canMoveLeft == true && isMoving == false)
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
        #endregion
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

    private void Rock()
    {
        if(throwRock == true)
        {
            backwardMR.enabled = true;
            forwardMR.enabled = true;
            leftMR.enabled = true;
            rightMR.enabled = true;
            isMoving = true;
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



