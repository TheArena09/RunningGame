using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMove : MonoBehaviour {

    
    public float eSpeed;
    public Vector2 resetPos;

    void Start()
    {
        
    }


    void Update()
    {
        
        transform.Translate(Vector2.left * eSpeed * Time.deltaTime);

        if (transform.position.x < -9)
        {
            //Destroy(gameObject);
            transform.position = resetPos;
        }
        

         
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.transform.name == "Player")
        {
            Debug.Log("충돌!!!!!");
        }
    }
}


