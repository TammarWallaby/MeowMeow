using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelToSample : MonoBehaviour
{
    GameObject levelController;
    void Start()
    {
        levelController = GameObject.Find("LevelUIController");
    }

    // Update is called once per frame
    void Update()
    {
        if (LevelUIController.loadingTime < 0f)
        {
            SceneManager.LoadScene("SampleScene");
            Destroy(levelController); 
        }
    }
}
