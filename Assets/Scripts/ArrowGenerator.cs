using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowGenerator : MonoBehaviour
{
    public GameObject arrowPrefab;
    public GameObject generatorPrefab;
    
    float span = 1.0f;
    float delta = 0f;

    private void Start()
    {
        span = 1/LevelUIController.levelNumber;
        
        for(int i=0;i<LevelUIController.levelNumber+2;i++)
        {
            GameObject gp = Instantiate(generatorPrefab);
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void FixedUpdate()
    {
        this.delta += Time.deltaTime;
        if(this.delta>this.span)
        {
            this.delta = 0;
            GameObject go = Instantiate(arrowPrefab);
            float px = Random.Range(-8f, 8f);
            go.transform.position = new Vector3(px, 7, -1);
        }
    }
}
