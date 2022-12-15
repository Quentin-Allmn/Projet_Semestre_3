using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BloodManager : MonoBehaviour
{

    public bool bloodIsActive = false;

    [SerializeField] Sprite check;
    [SerializeField] Sprite Error;

    [SerializeField] Button bloodBtn;


    private void Start()
    {
        bloodBtn.image.sprite = Error;
    }

    public void ActivateBlodd()
    {
        if(bloodIsActive == true)
        {
            bloodBtn.image.sprite = Error;
            bloodIsActive = false;
        }

        else if (bloodIsActive == false)
        {
            bloodBtn.image.sprite = check;
            bloodIsActive = true;
        }

    }


}
