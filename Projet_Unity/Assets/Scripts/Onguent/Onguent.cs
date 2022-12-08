using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Onguent : MonoBehaviour
{

    [SerializeField] Light lightOnguent;

    public bool isOintment = false;

    public int counterOintment = 0;

    private void Start()
    {
        
    }

    private void OnMouseDown()
    {

        isOintment = true;
        counterOintment = 0;
        lightOnguent.gameObject.SetActive(false);
    }


    private void Update()
    {
        if (counterOintment > 5)
        {
            isOintment = false;
            lightOnguent.gameObject.SetActive(true);
        }

        if (isOintment == true)
        {
            GetComponent<Outline>().enabled = true;
        }
        else
        {
            GetComponent<Outline>().enabled = false;
        }

    }
}
