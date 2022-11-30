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

    [SerializeField] Image victory;

    public bool bleedingPhase = false;
    public bool puzzlePhase = false;
    public bool OintmentPhase = false;
    public bool puzzleCompleted = false;

    public int bleedingCount = 0;
    public int ointmentCount = 0;

    Scalpel scalpel;

    Onguent onguent;

    public int boneCounter = 0;

    private void Awake()
    {
        scalpel = FindObjectOfType<Scalpel>();
        onguent = FindObjectOfType<Onguent>();
        bleedingPhase = true;
    }

    private void Update()
    {
        if (bleedingCount == listWounds.Count)
        {
            bleedingPhase = false;
            puzzlePhase = true;
            for (int i = 0; i < listWounds.Count; i++)
            {
                listWounds[i].gameObject.SetActive(false);
            }
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
            //KingLeg.SetActive(true);
        }




        if (ointmentCount == listWounds.Count)
        {
            victory.gameObject.SetActive(true);
        }



    }

}
