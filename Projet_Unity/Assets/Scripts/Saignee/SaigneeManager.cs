using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SaigneeManager : MonoBehaviour
{

    [SerializeField] public List<Bleeding> listBleeding = new List<Bleeding>();
    [SerializeField] GameObject stockOintment;

    [SerializeField] Image victory;
    [SerializeField] Image defeat;

    [SerializeField] Image bar;

    [SerializeField] Text textBleeding;

    public int bleedingCount = 0;
    public int ointmentCount = 0;

    public bool bleedingFinished = false;
    public bool ointmentFinished = false;

    private float timeMax = 25f;
    //private float timeMin = 0f;
    private float timeOintment;
    private float timeBleeding;

    private void Start()
    {
        timeOintment = timeMax / 2;
        timeBleeding = timeMax;

    }



    private void Update()
    {
        
        if (bleedingCount == listBleeding.Count)
        {
            stockOintment.SetActive(true);
        }

        if (ointmentCount == listBleeding.Count)
        {
            ointmentFinished = true;
            victory.gameObject.SetActive(true);
        }

        if (bleedingCount > 0)
        {

            timeBleeding -= Time.deltaTime;
            Debug.Log("ca saigne");

        }


        if (timeBleeding < timeOintment)
        {
            Debug.Log("Faut Heal");
            bleedingFinished = true;
            bar.color = new Color(255, 0, 0);
            textBleeding.text = "Heal";
        }

        if (timeBleeding <= 0)
        {
            defeat.gameObject.SetActive(true);
        }

        timeBleeding = Mathf.Clamp(timeBleeding, 0, timeMax);
        float amount = (float)timeBleeding / timeMax;
        bar.fillAmount = amount;

    }


}
