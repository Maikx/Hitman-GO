using System.Collections;
using System.Collections.Generic;
using System.Transactions;
using UnityEngine;
using UnityEngine.AI;

public class PlayerController : MonoBehaviour
{
    public float speed;
    public bool isMoving;
    private Waypoints wpS;


    void Start()
    {
        wpS = GameObject.Find("Level").GetComponent<Waypoints>();
        isMoving = false;
    }

    void Update()
    {
        MoveToWayPoint();
    }

    void MoveToWayPoint()
    {
        if (transform.position != wpS.waypoint[wpS.current].position)
        {
            Vector3 pos = Vector3.MoveTowards(transform.position, wpS.waypoint[wpS.current].position, speed * Time.deltaTime);
            GetComponent<Rigidbody>().MovePosition(pos);
            isMoving = true;
        }
        else
        {
            isMoving = false;
        }
        if (Input.GetKeyDown(KeyCode.D) && isMoving == false)
        {
            wpS.current = (wpS.current + 1); //% waypoint.Length;
        }
    }
}
