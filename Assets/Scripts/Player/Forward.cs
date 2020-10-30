using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Forward : MonoBehaviour
{
    private PlayerController pC;

    public Transform forward;


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
        if (Input.GetKey(KeyCode.W) && pC.canMoveForward == true && pC.isMoving == false)
        {
            pC.target = forward;
            pC.canMoveForward = false;
        }
    }

    //This is where the position of the waypoint is stored.
    private void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.layer == 0)
        {
            pC.canMoveForward = true;
            forward = collision.gameObject.transform;
        }
    }
}
