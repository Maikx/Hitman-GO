using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Catch : MonoBehaviour
{
    private Enemy enemy;
    private PlayerController pC;

    void Start()
    {
        pC = GameObject.Find("Player").GetComponent<PlayerController>();
        enemy = GameObject.Find("Enemy Test").GetComponent<Enemy>();
    }

    private void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            pC.isMoving = true;
            enemy.target = collision.gameObject.transform;
        }
    }
}
