using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FractureSceneManager : MonoBehaviour
{
    [SerializeField] GameObject kingLegOpened;
    [SerializeField] GameObject KingLeg;

    [SerializeField] GameObject slots;
    [SerializeField] GameObject bones;

    [SerializeField] public List<Cut> listWounds = new List<Cut>();
    [SerializeField] GameObject woundFinal;


    [SerializeField] Image victory;
    [SerializeField] Image defeat;

    [SerializeField] Image imageMission;

    [SerializeField] GameObject cutLines;

    [SerializeField] GameObject pliers;

    [SerializeField] ParticleSystem fireWorks;
    private bool fireWorksStarts = false;

    public bool bleedingPhase = false;
    public bool puzzlePhase = false;
    public bool OintmentPhase = false;
    public bool puzzleCompleted = false;

    public int bleedingCount = 0;
    public int ointmentCount = 0;

    [SerializeField] private float timeMax = 25f;
    private float timeFracture;
    [SerializeField] Image bar;

    Scalpel scalpel;

    Onguent onguent;

    CutSign cutSign;

    public int boneCounter = 0;

    private bool isWin = false;

    public bool isPause = false;

    private void Awake()
    {
        scalpel = FindObjectOfType<Scalpel>();
        onguent = FindObjectOfType<Onguent>();
        bleedingPhase = true;
        cutSign = FindObjectOfType<CutSign>();

        timeFracture = timeMax;

        

    }

    private void Start()
    {
        cutSign.canFire = true;
        cutSign.destructionDelay = 0.4f;
    }

    private void Update()
    {
        if (bleedingCount == listWounds.Count)
        {
            bleedingPhase = false;
            cutSign.canFire = false;
            puzzlePhase = true;
            for (int i = 0; i < listWounds.Count; i++)
            {
                listWounds[i].gameObject.SetActive(false);
            }
            cutLines.SetActive(false);
           // KingLeg.SetActive(false);
            kingLegOpened.SetActive(true);
            bones.SetActive(true);
            slots.SetActive(true);



        }

        if (boneCounter >= 3)
        {
            puzzlePhase = false;
            OintmentPhase = true;

            kingLegOpened.gameObject.SetActive(false);
            slots.SetActive(false);

            woundFinal.SetActive(true);
        }

        if (isPause == false && isWin == false)
        {
            timeFracture -= Time.deltaTime;
        }



        if (ointmentCount == listWounds.Count)
        {
            victory.gameObject.SetActive(true);
            isWin = true;
            KingLeg.SetActive(false);
            woundFinal.SetActive(false);
            if (fireWorksStarts == false)
            {
                fireWorksStarts = true;
                fireWorks.Play();
            }
        }

        if (timeFracture <= 0 && isWin == false)
        {
            defeat.gameObject.SetActive(true);
        }

        timeFracture = Mathf.Clamp(timeFracture, 0, timeMax);
        float amount = (float)timeFracture / timeMax;
        bar.fillAmount = amount;

    }

    public void AcceptMission()
    {
        imageMission.gameObject.SetActive(false);
        isPause = false;
    }

}
