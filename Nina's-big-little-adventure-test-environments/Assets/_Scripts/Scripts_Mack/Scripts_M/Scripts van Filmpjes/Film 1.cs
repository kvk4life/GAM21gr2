using UnityEngine;
using System.Collections;

public class Film1 : MonoBehaviour {
	//Om private classes buiten hun class te manipuleren
	private int level;

	public int Level {
		get{
			return level += 3;
		}
		set{
			level = value;
		}
	}
}
