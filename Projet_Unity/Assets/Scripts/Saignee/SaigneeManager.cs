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

    [SerializeField] Material wood;
    [SerializeField] Material flicker;

    [SerializeField] GameObject bloodParticle1;
    [SerializeField] GameObject bloodParticle2;

    public int bleedingCount = 0;
    public int ointmentCount = 0;

    public bool bleedingFinished = false;
    public bool ointmentFinished = false;

    [SerializeField] float timeMax = 25f;
    //private float timeMin = 0f;
    private float timeOintment;
    private float timeBleeding;

    Onguent onguent;

    private bool isWin = false;

    private void Start()
    {
        timeOintment = timeMax / 2;
        timeBleeding = timeMax;

        onguent = FindObjectOfType<Onguent>();

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
            bloodParticle2.SetActive(false);
            isWin = true;
        }

        if (bleedingCount > 0)
        {

            timeBleeding -= Time.deltaTime;
            Debug.Log("ca saigne");
            bloodParticle1.SetActive(true);

        }


        if (timeBleeding < timeOintment)
        {
            Debug.Log("Faut Heal");
            bleedingFinished = true;
            bar.color = new Color(255, 0, 0);
            textBleeding.text = "Heal";
            onguent.GetComponentInChildren<MeshRenderer>().material = flicker;
            bloodParticle2.SetActive(true);
            bloodParticle1.SetActive(false);
        }

        if (timeBleeding < timeOintment - 0.5)
        {
            onguent.GetComponentInChildren<MeshRenderer>().material = wood;
        }

        if (timeBleeding <= 0 && isWin == false)
        {
            defeat.gameObject.SetActive(true);
        }

        timeBleeding = Mathf.Clamp(timeBleeding, 0, timeMax);
        float amount = (float)timeBleeding / timeMax;
        bar.fillAmount = amount;

    }


}
