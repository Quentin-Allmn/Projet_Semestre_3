using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Options : MonoBehaviour
{

    [SerializeField] Image optionImage;



    public void OpenOption()
    {
        optionImage.gameObject.SetActive(true);
    }

    public void Back()
    {
        optionImage.gameObject.SetActive(false);
    }

    public void Volume()
    {

    }

}
