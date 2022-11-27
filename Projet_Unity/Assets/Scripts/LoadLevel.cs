using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadLevel : MonoBehaviour
{

    public void LevelLoader(int sceneIndex)
    {
        SceneManager.LoadSceneAsync(sceneIndex);
    }

}
