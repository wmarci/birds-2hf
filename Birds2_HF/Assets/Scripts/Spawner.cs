using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour {


    public GameObject [] EnemyPatterns;

    private float timeBtwSpawn;
    public float startTimeBtwSpawn;
    public float decreaseTime;
    public float minTime = 0.65f;



	void Start () {
		
	}
	
	
	void Update () {

        if (timeBtwSpawn <= 0)
        {

            int rand = Random.Range(0, EnemyPatterns.Length);
            Instantiate(EnemyPatterns[rand], transform.position, Quaternion.identity);
            timeBtwSpawn = startTimeBtwSpawn;

            if (startTimeBtwSpawn > minTime) {

                startTimeBtwSpawn -= decreaseTime; // ennyivel korábban jön a következő ellenfél

            }

        }
        else {

            timeBtwSpawn -= Time.deltaTime;

        }

	}
}
