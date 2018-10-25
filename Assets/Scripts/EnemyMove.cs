using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMove : MonoBehaviour {

    
    public float eSpeed = 4;
    public Vector2 resetPos;
    public float delay;
    public GameObject bgObj;



    void Start()
    {
        bgObj = GameObject.Find("BG");
        eSpeed = bgObj.GetComponent<BackGroundMove>().speed;
        eSpeed *= 4;
    }


    public void Update()
    {

        transform.Translate(Vector2.left * eSpeed * Time.deltaTime);

        if (transform.position.x < -12f)
        {
            Destroy(gameObject);
            //transform.position = resetPos;
        }

       /* 
        * delay += Time.deltaTime;
        if (delay >= 10f)
        {
            eSpeed = eSpeed + 1f;
            delay = 0f;
        }
        if (eSpeed >= 9f)
        {
            eSpeed = 12f;
        } 
        */

    }
    
   /* 
    * private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.transform.name == "Player")
        {
            Debug.Log("충돌!!!!!");
        }
    } 
    */
}


