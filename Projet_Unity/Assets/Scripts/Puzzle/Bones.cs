using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bones : MonoBehaviour
{

    [SerializeField] float posZ = 5;

    private bool isClicked = false;

    private bool canTrigger = false;

    [SerializeField] private GameObject targetBone;

    [SerializeField] Material visible;

    FractureSceneManager fractureScene;

    BoneSlot boneSlot;

    private void Awake()
    {
        fractureScene = FindObjectOfType<FractureSceneManager>();
        boneSlot = FindObjectOfType<BoneSlot>();
    }

    private void OnMouseDown()
    {
        isClicked = true;
    }

    private void OnMouseUp()
    {
        isClicked = false;
        canTrigger = true;
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
            transform.position = new Vector3(transform.position.x, transform.position.y, 2.2f);
        }

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "BoneSlot" && canTrigger == true)
        {
            if (other.gameObject.GetComponent<BoneSlot>().haveBone == false)
            {
                other.gameObject.GetComponent<BoneSlot>().haveBone = true;
                gameObject.SetActive(false);
                other.gameObject.GetComponent<MeshRenderer>().material = visible;
                fractureScene.boneCounter += 1;
            }
        }


    }

    private void OnTriggerExit(Collider other)
    {
        
    }
}
