using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Operation02 : MonoBehaviour
{
    [SerializeField] int indexScene;

    public bool isFinished = false;

    private void OnMouseDown()
    {
        if (PlayerPrefs.GetString("Op02") != "true")
        {
            PlayerPrefs.SetString("Op02", "true");
            SceneManager.LoadSceneAsync(indexScene);
        }
    }

    private void Update()
    {
        if (PlayerPrefs.GetString("Op02") == "true")
        {
            gameObject.SetActive(false);
        }
    }

}
