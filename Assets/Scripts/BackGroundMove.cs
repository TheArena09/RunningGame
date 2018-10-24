using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BackGroundMove : MonoBehaviour {


    public Renderer bg;
    public float speed = 0f;
    public float distance;
    public float delay = 0f;

    public GameObject distanceText;

    void Start()
    {
        bg = GetComponent<Renderer>();
    }


    void Update()
    {
        float offset = Time.time * speed;
        bg.material.SetTextureOffset("_MainTex", new Vector2(offset, 0));

        distance += Time.deltaTime;
        distanceText.GetComponent<Text>().text = "Distance: " + (int)distance + "m"; // 거리 text 표시

        delay += Time.deltaTime;  // 30초가 증가할때마다 빨라지는 배경 속력 구간  
        if (10f <= delay)
        {
            delay = 0f;
            speed += 0.2f;
            distance += speed;
        }

        


    }
}

   

