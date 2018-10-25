using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleMove : MonoBehaviour {

    public float oSpeed;
    public GameObject bgObj;

    void Start ()
    {
        bgObj = GameObject.Find("BG");
        oSpeed = bgObj.GetComponent<BackGroundMove>().speed;
        oSpeed *= 1.3f;
    }


    void Update()
    {
        transform.Translate(Vector2.left * oSpeed * Time.deltaTime);

        if (transform.position.x < -12f)
        {
            Destroy(gameObject);
        }
    }
}
