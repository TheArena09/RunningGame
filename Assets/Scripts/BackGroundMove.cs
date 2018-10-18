using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackGroundMove : MonoBehaviour {


    public Renderer bg;
    public float speed;

    void Start()
    {
        bg = GetComponent<Renderer>();
    }


    void Update()
    {
        float offset = Time.time * speed;
        bg.material.SetTextureOffset("_MainTex", new Vector2(offset, 0));
    }
}
