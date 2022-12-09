using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MiniGame1Manager : MonoBehaviour
{

    [SerializeField] public List<Wound> wounds = new List<Wound>();

    [SerializeField] int timeLeftInfection = 15;

    [SerializeField] Image imageInfection;

    [SerializeField] Image background;
    [SerializeField] Image victory;
    [SerializeField] Image defeat;

    [SerializeField] Image imageMission;

    public int woundCount = 0;


    public float infection = 0f;

    [SerializeField] Text ointmentTxt;
    public bool isOintmentText = false;

    private bool isWin = false;

    public bool isPause = true;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if ( woundCount >= wounds.Count)
        {

            victory.gameObject.SetActive(true);
            background.gameObject.SetActive(true);
            isWin = true;
        }

        if (isPause == false && isWin == false)
        {

            infection += Time.deltaTime;

        }

        infection = Mathf.Clamp(infection, 0f, timeLeftInfection);
        float amount = (float)infection / timeLeftInfection;
        imageInfection.fillAmount = amount;


        if (infection >= timeLeftInfection && isWin == false)
        {
            defeat.gameObject.SetActive(true);
            background.gameObject.SetActive(true);
        }

        if (isOintmentText == true)
        {
            ointmentTxt.gameObject.SetActive(true);
        }
        else if (isOintmentText == false)
        {
            ointmentTxt.gameObject.SetActive(false);
        }

    }

    public void AcceptMission()
    {
        imageMission.gameObject.SetActive(false);
        isPause = false;
    }
}
