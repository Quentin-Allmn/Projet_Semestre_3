using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Onguent : MonoBehaviour
{

    [SerializeField] Light light;

    public bool isOintment = false;

    public int counterOintment = 0;

    private void Start()
    {
        
    }

    private void OnMouseDown()
    {

        isOintment = true;
        counterOintment = 0;
        light.gameObject.SetActive(false);
    }


    private void Update()
    {
        if (counterOintment > 5)
        {
            isOintment = false;
            light.gameObject.SetActive(true);
        }
    }
}
