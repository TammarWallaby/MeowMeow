using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowController : MonoBehaviour
{
    GameObject player;

    // Start is called before the first frame update
    void Start()
    {
        this.player = GameObject.Find("player");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void FixedUpdate()
    {
        transform.Translate(0, -LevelUIController.levelNumber*0.05f, 0);

        if (transform.position.y < -5.0f)
            Destroy(gameObject);

        Vector2 p1 = transform.position;
        Vector2 p2 = this.player.transform.position;
        Vector2 dir = p1 - p2;
        float d = dir.magnitude;
        float r1 = 0.3f; // 화살 판정
        float r2 = 0.3f; // 플레이어 판정

        if( d<r1+r2)
        {
            Destroy(gameObject);
            Destroy(this.player);

        }




    }
}
