﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Left : MonoBehaviour
{
    private PlayerController pC;

    public Transform left;


    void Start()
    {
        pC = GameObject.Find("Player").GetComponent<PlayerController>();
    }


    void Update()
    {
        KeyBinding();
    }

    //This is where the Target is set from the colliding object.
    public void KeyBinding()
    {
        if (Input.GetKey(KeyCode.A) && pC.canMoveLeft == true && pC.isMoving == false)
        {
            pC.target = left;
            pC.canMoveForward = false;
            pC.canMoveRight = false;
            pC.canMoveBackward = false;
            pC.canMoveLeft = false;
        }
    }

    //This is where the position of the waypoint is stored.
    private void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.layer == 9)
        {
            pC.canMoveLeft = true;
            left = collision.gameObject.transform;
        }

        if (collision.gameObject.layer == 8)
        {
            pC.canMoveLeft = false;
        }
    }
}
