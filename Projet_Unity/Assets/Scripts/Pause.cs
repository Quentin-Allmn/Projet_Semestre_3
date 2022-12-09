using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Pause : MonoBehaviour
{

    [SerializeField] Image pauseMenu;

    MiniGame1Manager MiniGame1Manager;

    SaigneeManager saigneeManager;

    FractureSceneManager fractureScene;

    private void Start()
    {
        MiniGame1Manager = FindObjectOfType<MiniGame1Manager>();
        saigneeManager = FindObjectOfType<SaigneeManager>();
        fractureScene = FindObjectOfType<FractureSceneManager>();
    }

    public void ShowPauseMenu()
    {
        pauseMenu.gameObject.SetActive(true);
        MiniGame1Manager.isPause = true;
    }

    public void Back()
    {
        pauseMenu.gameObject.SetActive(false);
        MiniGame1Manager.isPause = false;
    }


    public void ShowPauseMenu2()
    {
        pauseMenu.gameObject.SetActive(true);
        saigneeManager.isPause = true;
    }

    public void Back2()
    {
        pauseMenu.gameObject.SetActive(false);
        saigneeManager.isPause = false;
    }


    public void ShowPauseMenu3()
    {
        pauseMenu.gameObject.SetActive(true);
        fractureScene.isPause = true;
    }

    public void Back3()
    {
        pauseMenu.gameObject.SetActive(false);
        fractureScene.isPause = false;
    }

}
