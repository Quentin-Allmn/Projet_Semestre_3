using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CutSign : MonoBehaviour
{

    [SerializeField] GameObject signObj;
    [SerializeField] public float fireRate = 1f;
    private float nextFire = 0.0f;

    public float destructionDelay = 0.2f;

    public bool canFire = true;

    Vector3 aimDirection;

    private void Start()
    {
        aimDirection = transform.forward;
        //Shoot();
    }

    private void Update()
    {
        if (Time.time > nextFire && canFire == true)
        {
            nextFire = Time.time + fireRate;
            Shoot();
        }
    }

    void Shoot()
    {
        GameObject sign = Instantiate(signObj, transform);
        sign.transform.position = transform.position;
        sign.GetComponent<Sign>().ShootDirection(aimDirection);
        Destroy(sign, destructionDelay);
    }

}
