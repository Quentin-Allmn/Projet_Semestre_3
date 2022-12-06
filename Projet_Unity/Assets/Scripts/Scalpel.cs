using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scalpel : MonoBehaviour
{

    public bool isActive = false;

    Onguent onguent;

    //Pliers pliers;

    private void Start()
    {
        onguent = FindObjectOfType<Onguent>();
        //pliers = FindObjectOfType<Pliers>();
    }

    private void OnMouseOver()
    {
        isActive = true;
        onguent.isOintment = false;
        //pliers.isActive = false;
    }

    private void Update()
    {
        if(onguent.isOintment == true)
        {
            isActive = false;
        }

        //if (pliers.isActive == true)
        //{
        //    isActive = false;
        //}
    }

}
