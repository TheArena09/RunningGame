using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour {

    /*public enum MOVEMENT
    {
        run=0,
        jump,
        down,
        walk
    }*/
    private Rigidbody2D rd;

    public float jumpSpeed;

    public bool jumping=false;

	void Start ()
    {
        rd = GetComponent<Rigidbody2D>();

	}
	
	
	void Update ()
    {
        /* 
         * if (Input.GetKey(KeyCode.Space))
         {
            rd.velocity = new Vector2(rd.velocity.x, 0);
            rd.AddForce(new Vector2(0, jumpSpeed));
         }
         */
         
      /* if (Input.GetKeyDown(KeyCode.Space))
        {
            GetComponent<Rigidbody2D>().velocity = new Vector2(GetComponent<Rigidbody2D>().velocity.x, jumpSpeed);
        } 
        */
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (jumping == false)
            {
                jumping = true;
                GetComponent<Rigidbody2D>().AddForce(Vector3.up * jumpSpeed);
            }
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.transform.name == "Ground")
        {
            jumping = false;
        }
    }

}
