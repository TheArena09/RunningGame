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

    public float jump;

    public float jumpLimit;

	void Start ()
    {
        rd = GetComponent<Rigidbody2D>();

	}
	
	
	void FixedUpdate ()
    {
        /* if (Input.GetKey(KeyCode.Space))
         {
            rd.velocity = new Vector2(rd.velocity.x, 0);
            rd.AddForce(new Vector2(0, jump));
         }*/
         
       if (Input.GetKeyDown(KeyCode.Space))
        {
            GetComponent<Rigidbody2D>().velocity = new Vector2(GetComponent<Rigidbody2D>().velocity.x, jump);
        } 
    }
   
}
