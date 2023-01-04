using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public Operations operations;
    public Operation02 operations2;
    public Operation03 operations3;


    [SerializeField] Image victoryImg;

    private void Start()
    {
        operations = FindObjectOfType<Operations>();
        operations2 = FindObjectOfType<Operation02>();
        operations3 = FindObjectOfType<Operation03>();
    }

    private void Update()
    {

        if (operations.isFinished == true && operations2.isFinished == true && operations3.isFinished == true)
        {
            victoryImg.gameObject.SetActive(true);
        }
        
    }

}
