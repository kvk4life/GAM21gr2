using UnityEngine;
using System.Collections;

public class CamConHead : MonoBehaviour {
	public int speed;
	public Vector3 rotatieAs;

	void Update () {
		CameraController ();
		ClampCam ();
	}

	void CameraController (){
		rotatieAs.x = Input.GetAxis ("Mouse Y");
		transform.Rotate (rotatieAs * speed * Time.deltaTime);
	}

	void ClampCam (){
		float yPos = transform.position.y;
		yPos = Mathf.Clamp (yPos,1,5);
	}
}