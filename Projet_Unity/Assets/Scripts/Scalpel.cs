using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scalpel : MonoBehaviour
{

    public bool isActive = false;

    Onguent onguent;

    private void Start()
    {
        onguent = FindObjectOfType<Onguent>();
    }

    private void OnMouseOver()
    {
        isActive = true;
        onguent.isOintment = false;
    }

    private void Update()
    {
        if(onguent.isOintment == true)
        {
            isActive = false;
        }
    }

}
