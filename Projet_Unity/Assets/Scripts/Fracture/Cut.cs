using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cut : MonoBehaviour
{



    [SerializeField] Material wound;
    [SerializeField] Material onguent;

    [SerializeField] GameObject cutParticle;

    private bool isWound = false;
  //  private bool isOintment = false;

    FractureSceneManager fractureSceneManager;

    Onguent Onguent;

    Scalpel scalpel;

    Vector3 pos;
    // Start is called before the first frame update
    void Start()
    {
        fractureSceneManager = FindObjectOfType<FractureSceneManager>();
        Onguent = FindObjectOfType<Onguent>();
        scalpel = FindObjectOfType<Scalpel>();

        pos = new Vector3(transform.position.x, transform.position.y, transform.position.z - 1);
    }

    private void OnMouseOver()
    {
        if (scalpel.isActive == true)
        {
            if (isWound == false)
            {
                isWound = true;

                var Cut = Instantiate(cutParticle, pos , Quaternion.identity);
                Destroy(Cut, 1);

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
