using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bleeding : MonoBehaviour
{


    [SerializeField] Material wound;
    [SerializeField] Material onguent;

    [SerializeField] GameObject cutParticle;

    private bool isWound = false;
    private bool isOintment = false;

    SaigneeManager saigneeManager;

    Onguent Onguent;

    Vector3 pos;

    Scalpel scalpel;
    // Start is called before the first frame update
    void Start()
    {
        saigneeManager = FindObjectOfType<SaigneeManager>();
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

                var Cut = Instantiate(cutParticle, pos, Quaternion.identity);
                Destroy(Cut, 1);

                gameObject.GetComponent<MeshRenderer>().material = wound;

                saigneeManager.bleedingCount += 1;
            }

        }

        if (saigneeManager.bleedingFinished == true && isOintment == false)
        {
            if (isWound == true && Onguent.isOintment == true)
            {
                Onguent.counterOintment += 1;

                isOintment = true;

                gameObject.GetComponent<MeshRenderer>().material = onguent;

                saigneeManager.ointmentCount += 1;
            }
        }



    }

    // Update is called once per frame
    void Update()
    {

    }


}
