using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControler : MonoBehaviour
{

    [SerializeField]
    DynamicJoystick joystickMove;

    [SerializeField]
    DynamicJoystick joystickCamera;

    [SerializeField]
    Camera camera;

    [SerializeField]
    float moveSpeed = 0;

    [SerializeField]
    float acceleration = 0.1f;

    [SerializeField]
    float speedMax = 10;

    [SerializeField]
    float decceleration = 0.1f;

    [SerializeField]
    float smoothRotation = 0.1f;

    Vector3 moveDirection;
    Vector3 camDirection;

    GameManager gameManager;

    Rigidbody rb;


    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
        gameManager = FindObjectOfType<GameManager>();
    }

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (joystickMove.Direction.magnitude > 0)
        {
            moveDirection = new Vector3(joystickMove.Direction.x, 0, joystickMove.Direction.y).normalized;
            moveSpeed = Mathf.Lerp(moveSpeed, speedMax, acceleration) * joystickMove.Direction.magnitude;
        }

        else
        {
            moveSpeed = Mathf.Lerp(moveSpeed, 0, decceleration);
        }

        if (joystickCamera.Direction.magnitude > 0)
        {
            camDirection = new Vector3(joystickCamera.Direction.x, 0, joystickCamera.Direction.y).normalized;
            
        }

    }

    private void FixedUpdate()
    {
        rb.velocity = moveDirection * moveSpeed;
    }

}
