using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Backward : MonoBehaviour
{
    private PlayerController pC;

    public Transform backward;

    // Start is called before the first frame update
    void Start()
    {
        pC = GameObject.Find("Player").GetComponent<PlayerController>();
    }

    // Update is called once per frame
    void Update()
    {
        KeyBinding();
    }

    //This is where the Target is set from the colliding object.
    public void KeyBinding()
    {
        if (Input.GetKey(KeyCode.S) && pC.canMoveBackward == true && pC.isMoving == false)
        {
            pC.target = backward;
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
            pC.canMoveBackward = true;
            backward = collision.gameObject.transform;
        }

        if (collision.gameObject.layer == 8)
        {
            pC.canMoveBackward = false;
        }
    }

}
