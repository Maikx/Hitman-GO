using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Right : MonoBehaviour
{
    private PlayerController pC;
    

    public Transform right;

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
        if (Input.GetKey(KeyCode.D) && pC.canMoveRight == true && pC.isMoving == false)
        {
            pC.target = right;
            pC.canMoveRight = false;
        }
    }

    //This is where the position of the waypoint is stored.
    private void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.layer == 0)
        {
            pC.canMoveRight = true;
            right = collision.gameObject.transform;
        }
    }
}
