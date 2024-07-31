using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelUIController : MonoBehaviour
{
    GameObject level;

    public static float levelNumber = 1;

    public static float loadingTime = 0f;
    // Start is called before the first frame update
    private void Awake()
    {
        
    }

    void Start()
    {
        loadingTime = 2f;
        
        level = GameObject.Find("LevelNumber");
        this.level.GetComponent<TextMeshProUGUI>().text = levelNumber.ToString("F0");

        levelNumber++;

        DontDestroyOnLoad(this.gameObject);

        
    }

    // Update is called once per frame
    void Update()
    {
        loadingTime -= Time.deltaTime;

    }
}
