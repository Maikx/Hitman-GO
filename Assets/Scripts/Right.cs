using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Right : MonoBehaviour
{
    private PlayerController pC;

    public Transform right;

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
        if (Input.GetKey(KeyCode.D) && pC.canMoveRight == true && pC.isMoving == false)
        {
            pC.target = right;
            pC.canMoveRight = false;
        }
    }

    private void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.tag == "Waypoint")
        {
            pC.canMoveRight = true;
            right = collision.gameObject.transform;
        }
    }
}
