using UnityEngine;
using System.Collections;

public class Respawn : MonoBehaviour {
	public Transform[] checkPoints;
	public int curCheckPoint;
	public GameObject Player;

	public int SetCheckPoint(int checkedPoint){
		curCheckPoint = checkedPoint;
		return curCheckPoint;
	}

	public void Respawning(){
		Instantiate (Player, checkPoints [curCheckPoint].position, checkPoints [curCheckPoint].rotation);
	}
}
