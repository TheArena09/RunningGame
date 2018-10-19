using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackGroundMove : MonoBehaviour {


    public Renderer bg;
    public float speed = 0f;
    
    float delay = 0f;

    void Start()
    {
        bg = GetComponent<Renderer>();
    }


    void Update()
    {
        float offset = Time.time * speed;
        bg.material.SetTextureOffset("_MainTex", new Vector2(offset, 0));

        delay += Time.deltaTime;  // 45초가 증가할때마다 빨라지는 배경 속력 구간
        if (45f <= delay)
        {
            delay = 0f;
            speed += 0.2f;
        }


    }
}

   

