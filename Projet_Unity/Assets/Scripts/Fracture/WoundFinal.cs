using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WoundFinal : MonoBehaviour
{

    [SerializeField] Material wound;
    [SerializeField] Material onguent;


    private bool isChanged = false;

    FractureSceneManager fractureSceneManager;

    Onguent Onguent;

    [SerializeField] GameObject onguentParticules;
    Vector3 pos;

    // Start is called before the first frame update
    void Start()
    {
        fractureSceneManager = FindObjectOfType<FractureSceneManager>();
        Onguent = FindObjectOfType<Onguent>();

        pos = new Vector3(transform.position.x, transform.position.y, transform.position.z - 1);
    }

    private void OnMouseOver()
    {
        if (isChanged == false && Onguent.isOintment == true)
        {
            Onguent.counterOintment += 1;

            isChanged = true;

            var Cut = Instantiate(onguentParticules, pos, Quaternion.identity);
            Destroy(Cut, 1);

            gameObject.GetComponent<MeshRenderer>().material = onguent;

            fractureSceneManager.ointmentCount += 1;

        }


    }

    // Update is called once per frame
    void Update()
    {

    }

}
