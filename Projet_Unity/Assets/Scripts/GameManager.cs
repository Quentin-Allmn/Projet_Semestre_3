using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{

    public bool mission3IsSucess = false;

    public int kingHealth = 100;

    LoadLevel LoadLevel;

    private void Awake()
    {
        LoadLevel = FindObjectOfType<LoadLevel>();
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (kingHealth <= 0)
        {
            Debug.Log("Game Over");
            LoadLevel.LevelLoader(5);
        }

        if (mission3IsSucess == true)
        {
            Debug.Log("Victory");
            LoadLevel.LevelLoader(5);
        }

    }
}
