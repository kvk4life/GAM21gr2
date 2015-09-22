using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Enemie_Insantiater : CurLevel{
	List<GameObject> spawnPoints = new List<GameObject>();
	List<GameObject> enemyPrefab = new List<GameObject>();	

	int enemyInsertingInt = 0;
	public static int enemyCount = 0;
	int enemyNumber;

	new void OnTriggerEnter(){
		EnemyInstanter ();
	}

	void EnemyInstanter(){
		for(int sPCount = 0; sPCount < enemyInsertingInt; sPCount++){
			int curSpawn = Random.Range (0, spawnPoints.Count);
			int curEnemy = curLevel;
			Vector3 spawnPos = new Vector3();
			Quaternion spawnRot = new Quaternion();
			spawnPos = spawnPoints[curSpawn].transform.position;
			spawnRot = spawnPoints[curSpawn].transform.rotation;
			Instantiate (enemyPrefab[curEnemy], spawnPos, spawnRot);
			enemyPrefab[curEnemy].GetComponent<Enemy_Stats>().number = enemyNumber;
			enemyNumber++;
			enemyCount++;
		}
	}
}
