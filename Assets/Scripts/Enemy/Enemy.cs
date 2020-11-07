using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    private Enemy enemy;
    private Catch catchS;
    private PlayerController pC;

    public float speed;
    public Transform target = null;

    void Start()
    {
        catchS = GameObject.Find("Front").GetComponent<Catch>();
        pC = GameObject.Find("Player").GetComponent<PlayerController>();
        enemy = GameObject.Find("Enemy Test").GetComponent<Enemy>();
    }


    void Update()
    {
        Catch();
    }

    public void Catch()
    {
        if (target != null)
        {
            float step = speed * Time.deltaTime;
            transform.position = Vector3.MoveTowards(transform.position, target.position, step);
        }
    }

    private void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.tag == "Player" && catchS.isPlayer == true)
        {
            Destroy(collision.gameObject);
        }
    }
}

