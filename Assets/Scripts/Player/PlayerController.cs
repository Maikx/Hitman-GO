using System.Collections;
using System.Collections.Generic;
using System.Transactions;
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

    public Transform playerpos;
    public Transform target = null;

    void Start()
    {
        right = GameObject.Find("Right").GetComponent<Right>();
        left = GameObject.Find("Left").GetComponent<Left>();
        forward = GameObject.Find("Forward").GetComponent<Forward>();
        backward = GameObject.Find("Backward").GetComponent<Backward>();
        isMoving = false;
        canMoveRight = false;
    }

    private void Update()
    {
        Movement();
    }

    private void Movement()
    {

        playerpos = gameObject.GetComponent<Transform>();

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

}



