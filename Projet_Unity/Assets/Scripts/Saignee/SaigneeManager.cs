using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SaigneeManager : MonoBehaviour
{

    [SerializeField] public List<Bleeding> listBleeding = new List<Bleeding>();
    [SerializeField] GameObject stockOintment;
    [SerializeField] Image victory;

    public int bleedingCount = 0;
    public int ointmentCount = 0;

    public bool bleedingFinished = false;
    public bool ointmentFinished = false;

    private void Start()
    {
        
    }

    private void Update()
    {
        
        if (bleedingCount == listBleeding.Count)
        {
            stockOintment.SetActive(true);
            bleedingFinished = true;
        }

        if (ointmentCount == listBleeding.Count)
        {
            ointmentFinished = true;
            victory.gameObject.SetActive(true);
        }

    }


}
