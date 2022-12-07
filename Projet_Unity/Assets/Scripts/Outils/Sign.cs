using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sign : MonoBehaviour
{
    [SerializeField] float speed = 10;
    public float destructionDelay = 0.2f;

    private void Start()
    {
        
    }

    private void Update()
    {
        
    }

    public void ShootDirection(Vector3 direction)
    {

        GetComponent<Rigidbody>().velocity = direction * speed;

        //Destroy(gameObject, destructionDelay);

    }

}
