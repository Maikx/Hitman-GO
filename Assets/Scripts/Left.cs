using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Left : MonoBehaviour
{
    private PlayerController pC;

    public Transform left;

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
        if (Input.GetKey(KeyCode.A) && pC.canMoveLeft == true && pC.isMoving == false)
        {
            pC.target = left;
            pC.canMoveLeft = false;
        }
    }

    private void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.tag == "Waypoint")
        {
            pC.canMoveLeft = true;
            left = collision.gameObject.transform;
        }
    }
}
