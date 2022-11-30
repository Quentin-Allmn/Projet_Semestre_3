using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cut : MonoBehaviour
{



    [SerializeField] Material wound;
    [SerializeField] Material onguent;


    private bool isWound = false;
  //  private bool isOintment = false;

    FractureSceneManager fractureSceneManager;

    Onguent Onguent;

    Scalpel scalpel;
    // Start is called before the first frame update
    void Start()
    {
        fractureSceneManager = FindObjectOfType<FractureSceneManager>();
        Onguent = FindObjectOfType<Onguent>();
        scalpel = FindObjectOfType<Scalpel>();
    }

    private void OnMouseOver()
    {
        if (scalpel.isActive == true)
        {
            if (isWound == false)
            {
                isWound = true;

                gameObject.GetComponent<MeshRenderer>().material = wound;

                fractureSceneManager.bleedingCount += 1;
            }

        }



    }

    // Update is called once per frame
    void Update()
    {

    }



}
