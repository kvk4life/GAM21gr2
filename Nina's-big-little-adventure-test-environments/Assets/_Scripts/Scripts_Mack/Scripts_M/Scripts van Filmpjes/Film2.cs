using UnityEngine;
using System.Collections;

public class Film2 : MonoBehaviour {
	public int num = 10;
	public string message;

	void Start() {
		message = num > 0? "num is meer dan 0": num == 0? "num is gelijk aan 0": "num is lager dan 0";
	}
}