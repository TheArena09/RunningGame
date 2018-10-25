using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleRespawner : MonoBehaviour {

    public Transform bin;

    public float timer = 0;

    void Start ()
    {
		
	}
	
	
	void Update ()
    {
        timer += Time.deltaTime;

        if (timer > 27f)
        {
            CreateObsta();
            timer = 0;
        }
        
    }
    void CreateObsta()
    {
        int ObstaNum = Random.Range(1,2);

        switch (ObstaNum)
        {
            case 1:
                Instantiate(bin, transform.position, Quaternion.identity);
                break;
           
        }
    }
}
