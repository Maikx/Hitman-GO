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

    public void KeyBinding()
    {
        if (Input.GetKey(KeyCode.S) && pC.canMoveBackward == true && pC.isMoving == false)
        {
            pC.target = backward;
            pC.canMoveBackward = false;
        }
    }

    private void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.tag == "Waypoint")
        {
            pC.canMoveBackward = true;
            backward = collision.gameObject.transform;
        }
    }

}
