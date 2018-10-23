using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyRespawner : MonoBehaviour {

    public Transform bicycle;
    public Transform bin;
    public Transform motocycle;

    public float timer = 0;

	void Start ()
    {
		
	}


    void Update()
    {
        timer += Time.deltaTime;

        if (timer > 2.3f)
        {
            CreateEnemy();
            timer = 0;
        }
    }
    void CreateEnemy()
    {
        int enemyNum = Random.Range(3, 10);

        switch (enemyNum)
        {
            case 1:
            Instantiate(bicycle, transform.position, Quaternion.identity);
            break;

            case 2:
            Instantiate(bin, transform.position, Quaternion.identity);
            break;

            case 3:
            Instantiate(motocycle, transform.position, Quaternion.identity);
            break;
        }
    }
	
}
