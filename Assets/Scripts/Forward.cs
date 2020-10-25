using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Forward : MonoBehaviour
{
    private PlayerController pC;

    public Transform forward;

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
        if (Input.GetKey(KeyCode.W) && pC.canMoveForward == true && pC.isMoving == false)
        {
            pC.target = forward;
            pC.canMoveForward = false;
        }
    }

    private void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.tag == "Waypoint")
        {
            pC.canMoveForward = true;
            forward = collision.gameObject.transform;
        }
    }
}
