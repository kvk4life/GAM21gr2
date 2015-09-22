using UnityEngine;
using System.Collections;

public class PoisonDeath : MonoBehaviour {
	public float poisonDamage;
	public float poisonRate;
	float nextPoison;

	bool mayPoison;

	public void OnTriggerEnter(Collider colE){
		if (colE.transform.tag == "Player") {
			nextPoison = Time.time;
		}
		else {
			return;
		}
	}
	
	public void OnTriggerStay(Collider colP){
		if (colP.transform.tag == "Player") {
			Poisoned (colP.gameObject);
		} 
		else {
			return;
		}
	}
	
	public void Poisoned(GameObject poisonedPlayer){
		if (!poisonedPlayer.GetComponent<BreathHolding> ().inSafeZone && !poisonedPlayer.GetComponent<BreathHolding> ().holdBreath) {
			mayPoison = true;
		}
		else {
			mayPoison = false;
		}

		if(mayPoison){
			if(Time.time > poisonRate + nextPoison){
				poisonedPlayer.GetComponent<PlayerHealth>().Damage(poisonDamage);
				nextPoison = Time.time;
			}
		}

//		if(!poisonedPlayer.GetComponent<BreathHolding>().inSafeZone || !poisonedPlayer.GetComponent<BreathHolding>().holdBreath){
//			if(Time.time > poisonRate + nextPoison){
//				poisonedPlayer.GetComponent<PlayerHealth>().Damage(poisonDamage);
//				nextPoison = Time.time;
//			}
//		}
	}
}
