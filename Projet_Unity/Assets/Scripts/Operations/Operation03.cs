using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Operation03 : MonoBehaviour
{
    [SerializeField] int indexScene;

    public bool isFinished = false;

    private void OnMouseOver()
    {
        if (isFinished == false)
        {
            SceneManager.LoadSceneAsync(indexScene);
        }
    }
}
