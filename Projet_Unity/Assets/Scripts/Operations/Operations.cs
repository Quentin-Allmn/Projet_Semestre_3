using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Operations : MonoBehaviour
{

    [SerializeField] int indexScene;

    public bool isFinished = false;

    private void OnMouseDown()
    {
        if (PlayerPrefs.GetString("Op01") != "true")
        {
            PlayerPrefs.SetString("Op01", "true");
            SceneManager.LoadSceneAsync(indexScene);
        }
    }


    private void Update()
    {
        if (PlayerPrefs.GetString("Op01") == "true")
        {
            gameObject.SetActive(false);
        }
    }



}
