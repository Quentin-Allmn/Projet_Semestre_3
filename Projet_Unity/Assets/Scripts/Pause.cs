using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Pause : MonoBehaviour
{

    [SerializeField] Image pauseMenu;

    MiniGame1Manager MiniGame1Manager;

    private void Start()
    {
        MiniGame1Manager = FindObjectOfType<MiniGame1Manager>();
    }

    public void ShowPauseMenu()
    {
        pauseMenu.gameObject.SetActive(true);
        MiniGame1Manager.ispause = true;
    }

    public void Back()
    {
        pauseMenu.gameObject.SetActive(false);
        MiniGame1Manager.ispause = false;
    }

}
