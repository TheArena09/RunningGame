using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemyRespawner : MonoBehaviour {

    public Transform bicycle;
    public Transform motocycle;
    

    public float timer = 0;
    public float delay = 0;
    
    
   
    void Start ()
    {
        
        

    }


    void Update()
    {
        timer += Time.deltaTime;
        if (timer > 7.2f)
        {
            CreateEnemy();
            timer = 0;
        }
        
    }
    void CreateEnemy()
    {
        int enemyNum = Random.Range(1,3);
        //delay += Time.deltaTime;

     

        switch (enemyNum)
        {
            case 1:
            Instantiate(bicycle, transform.position, Quaternion.identity);
            break;

            case 2:
            Instantiate(motocycle, transform.position, Quaternion.identity);
            break;
        }

        /* if (delay <= 10f)         이렇게 코딩하면 안됨  
       {
           delay = 0f;
           EnemyMove enemyMove = GameObject.Find("bicycle").GetComponent<EnemyMove>();
           enemyMove.eSpeed = eSpeed + 1f;

           EnemyMove enemyMove2 = GameObject.Find("motocycle").GetComponent<EnemyMove>();
           enemyMove2.eSpeed = eSpeed + 1f;
       } */ 
    }
}
