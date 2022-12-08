using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pliers : MonoBehaviour
{

    public bool isActive = false;

    Onguent onguent;

    Scalpel scalpel;

    private void Start()
    {
        onguent = FindObjectOfType<Onguent>();
        scalpel = FindObjectOfType<Scalpel>();
    }

    private void OnMouseOver()
    {
        isActive = true;
        onguent.isOintment = false;
        scalpel.isActive = false;
    }

    private void Update()
    {
        if (onguent.isOintment == true)
        {
            isActive = false;
        }

        if (scalpel.isActive == true)
        {
            isActive = false;
        }

        if(isActive == true)
        {
            GetComponent<Outline>().enabled = true;
        }
        else
        {
            GetComponent<Outline>().enabled = false;
        }
    }

}
