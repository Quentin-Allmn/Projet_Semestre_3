using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Onguent : MonoBehaviour
{

    public bool isOintment = false;

    public int counterOintment = 0;

    private void OnMouseDown()
    {

        isOintment = true;
        counterOintment = 0;
    }


    private void Update()
    {
        if (counterOintment > 4)
        {
            isOintment = false;
        }
    }
}
