using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundScript : MonoBehaviour {

    public Renderer bg;
    public float speed;

    void Start()
    {
        bg = GetComponent<Renderer>();
    }


    void Update()
    {
        float offset = Time.time * -speed;
        bg.material.SetTextureOffset("_MainTex", new Vector2(0,offset));
    }
}
