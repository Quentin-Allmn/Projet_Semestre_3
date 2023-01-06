using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Operation03 : MonoBehaviour
{
    [SerializeField] int indexScene;

    public bool isFinished = false;

    private void OnMouseDown()
    {
        if (PlayerPrefs.GetString("Op03") != "true")
        {
            PlayerPrefs.SetString("Op03", "true");
            SceneManager.LoadSceneAsync(indexScene);
        }
    }

    private void Update()
    {
        if (PlayerPrefs.GetString("Op03") == "true")
        {
            gameObject.SetActive(false);
        }
    }

}
