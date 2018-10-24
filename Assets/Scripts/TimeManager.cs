using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeManager : MonoBehaviour {

    public float timeLoad = 1;
    public float timeScale;

	void Start ()
    {
        
	}
	

	void Update ()
    {
        timeScale = timeScale * Time.deltaTime;

        if ( timeScale > 4f)
        {
            timeLoad = 2f * Time.deltaTime;
            timeScale = 0; 
        }
    }
}
