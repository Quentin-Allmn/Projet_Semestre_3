using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControler : MonoBehaviour
{
    [SerializeField]
    FixedJoystick joystick;

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
    Vector3 aimDirection;

    GameManager gameManager;

    // Cache
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
        if (joystick.Direction.magnitude > 0)
        {
            // Vecteur de direction de déplacement
            moveDirection = new Vector3(joystick.Direction.x, 0, joystick.Direction.y).normalized;
            moveSpeed = Mathf.Lerp(moveSpeed, speedMax, acceleration) * joystick.Direction.magnitude;

        }
        else
        {
            moveSpeed = Mathf.Lerp(moveSpeed, 0, decceleration);
        }

        //Orientation player
        transform.forward = Vector3.Lerp(transform.forward, aimDirection, smoothRotation);

    }

    private void FixedUpdate()
    {
        // Vélocité = direction * vitesse * inclinaison du joystick
        rb.velocity = moveDirection * moveSpeed;

    }

}
