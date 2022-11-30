using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bones : MonoBehaviour
{

    [SerializeField] float posZ = 5;

    private bool isClicked = false;

    private bool isSnap = false;

    [SerializeField] private GameObject targetBone;

    private void OnMouseDown()
    {
        isClicked = true;
    }

    private void OnMouseUp()
    {
        isClicked = false;
    }

    private void Update()
    {
        if (isClicked)
        {

            Vector3 mousePos = Input.mousePosition;
            mousePos.z = posZ;
            Vector3 position = Camera.main.ScreenToWorldPoint(mousePos);

            transform.position = position;
        }

        else
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, 2.1f);

            if (isSnap)
            {
                Debug.Log("pls");
               //Vector3 newPos = targetBone.transform.position.y;
            }

        }

    }

    private void OnTriggerEnter(Collider other)
    {
        isSnap = true;
        //other.gameObject = targetBone;
        Debug.Log(other.gameObject.transform);
        
    }

    private void OnTriggerExit(Collider other)
    {
        isSnap = false;
    }
}
