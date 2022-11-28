using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wound : MonoBehaviour
{

    [SerializeField] Material wound;
    [SerializeField] Material onguent;



    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void OnMouseOver()
    {

        Debug.Log(gameObject.GetComponent<MeshRenderer>().material);

        gameObject.GetComponent<MeshRenderer>().material = onguent;

        if (gameObject.GetComponent<MeshRenderer>().material == wound)
        {
            gameObject.GetComponent<MeshRenderer>().material = onguent;
            Debug.Log("Change Material");
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}
