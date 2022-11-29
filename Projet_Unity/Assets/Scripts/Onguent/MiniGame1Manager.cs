using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MiniGame1Manager : MonoBehaviour
{

    [SerializeField] public List<Wound> wounds = new List<Wound>();

    public int woundCount = 0;

    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        if ( woundCount >= 9)
        {
            Debug.Log("Victry");
        }
    }
}
