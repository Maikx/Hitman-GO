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

    public Quaternion initialRotationPos;
    public float smoothSpeed;


    private void Start()
    {
        startPos = transform.position;
        initialRotationPos = transform.rotation;
        
    }

    void Movement()
    {
       
        if (isPressed == true)
        {
            float x = Input.GetAxis("Mouse X") * speed * Time.deltaTime;
            float y = Input.GetAxis("Mouse Y") * speed * Time.deltaTime;

            rotation -= y;
            rotationY += x;
            rotation = Mathf.Clamp(rotation, -15f, 30f); //vertical
            rotationY = Mathf.Clamp(rotationY, -30f, 30f);  //horizontal
            parent.localRotation = Quaternion.Euler(0, rotationY,rotation);
        }

        if (isPressed == false)
        {
            transform.position = Vector3.Lerp(transform.position, startPos, Time.deltaTime * smoothSpeed);
            transform.rotation = Quaternion.Lerp(transform.rotation, initialRotationPos, Time.deltaTime * smoothSpeed);
        }
    }
    private void Update()
    {
        if (Input.GetMouseButton(0) || Input.GetMouseButton(1)) isPressed = true; else isPressed = false;
        Movement();
    }
}