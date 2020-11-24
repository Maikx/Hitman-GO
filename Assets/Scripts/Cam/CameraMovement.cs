using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    public Transform parent;
    public float speed = 10f;
    public float rotation;
    public float rotationY;
    public bool isPressed = false;

    public Transform currentPos;
    private GameManager gm;
    public Vector3 startPos;

   public Vector3 nextPosition;
   public float moveSpeed;

    private void Start()
    {
       // nextPosition = transform.position;

    }

    void Movement()
    {
        if (isPressed == true)
        {

            
            float x = Input.GetAxis("Mouse X") * speed * Time.deltaTime;
            float y = Input.GetAxis("Mouse Y") * speed * Time.deltaTime;

            rotation -= y;
            rotationY += x;
            rotation = Mathf.Clamp(rotation, -15f, 50f); //vertical
            rotationY = Mathf.Clamp(rotationY, -30f, 30f);  //horizontal
            parent.localRotation = Quaternion.Euler(0, rotationY,rotation);
           

 
        }

        if (isPressed == false)
        {
        }

    }

    private void Update()
    {
        if (Input.GetMouseButton(0) || Input.GetMouseButton(1)) isPressed = true; else isPressed = false;
        Movement();
    }

}

