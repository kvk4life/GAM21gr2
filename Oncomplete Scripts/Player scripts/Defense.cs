using UnityEngine;
using System.Collections;

public class Defense : MonoBehaviour {
	public bool blocken;

	public void Update(){
		Blocking ();
	}

	public void Blocking(){
		if (Input.GetButton ("Fire2")) {
			blocken = true;
		}
		else {
			blocken = false;
		}
	}
}
