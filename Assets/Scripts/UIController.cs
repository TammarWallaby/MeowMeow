using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIController : MonoBehaviour
{
    public GameObject player;
    
    GameObject timerText;

    public float time = 30.0f;

    

    void Start()
    {
        float time = 30.0f;
        this.timerText = GameObject.Find("TimeText");
         
    }

    
    void Update()
    {
        if(player==null)
        {
            SceneManager.LoadScene("GameOver");
        }

        this.time -= Time.deltaTime;

        

        this.timerText.GetComponent<TextMeshProUGUI>().text = this.time.ToString("F1");

        if(time<0f)
        {
            
            SceneManager.LoadScene("LevelUI");            
        }
    }
}
