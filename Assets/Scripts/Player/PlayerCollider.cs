using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollider : MonoBehaviour
{
    private PlayerController pC;
    private Catch catchS;

    // Start is called before the first frame update
    void Start()
    {
        pC = GameObject.Find("Player").GetComponent<PlayerController>();

        if (GameObject.FindWithTag("Enemy") != null) catchS = GameObject.Find("Front").GetComponent<Catch>(); 
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.tag == "Finish")
        {
            pC.isMoving = true;
        }
        if (collision.gameObject.tag == "Enemy" && catchS.isPlayer == false)
        {
            Destroy(collision.gameObject);
        }
    }
}
