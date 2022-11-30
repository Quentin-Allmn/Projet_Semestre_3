using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wound : MonoBehaviour
{

    [SerializeField] Material wound;
    [SerializeField] Material onguent;


    private bool isChanged = false;

    MiniGame1Manager miniGame1Manager;

    Onguent Onguent;



    // Start is called before the first frame update
    void Start()
    {
        miniGame1Manager = FindObjectOfType<MiniGame1Manager>();
        Onguent = FindObjectOfType<Onguent>();
        miniGame1Manager.isOintmentText = false;
    }

    private void OnMouseOver()
    {
        if (isChanged == false && Onguent.isOintment == true )
        {
            Onguent.counterOintment += 1;

            isChanged = true;

            gameObject.GetComponent<MeshRenderer>().material = onguent;

            miniGame1Manager.woundCount += 1;

            miniGame1Manager.isOintmentText = false;
        }

        if (Onguent.isOintment == false)
        {
            miniGame1Manager.isOintmentText = true;
        }

    }

    // Update is called once per frame
    void Update()
    {

    }
}
