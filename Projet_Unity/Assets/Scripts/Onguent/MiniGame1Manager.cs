using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MiniGame1Manager : MonoBehaviour
{

    [SerializeField] public List<Wound> wounds = new List<Wound>();

    [SerializeField] int timeLeftInfection = 15;

    [SerializeField] Image victory;
    [SerializeField] Image defeat;

    public int woundCount = 0;

    LoadLevel loadLevel;

    public float infection = 0f;

    

    // Start is called before the first frame update
    void Start()
    {
        loadLevel = FindObjectOfType<LoadLevel>();
    }

    // Update is called once per frame
    void Update()
    {
        if ( woundCount >= wounds.Count)
        {
            Debug.Log("Victry");

            victory.gameObject.SetActive(true);
        }

        infection += Time.deltaTime;

        if (infection >= timeLeftInfection)
        {
            defeat.gameObject.SetActive(true);
        }

    }


}
