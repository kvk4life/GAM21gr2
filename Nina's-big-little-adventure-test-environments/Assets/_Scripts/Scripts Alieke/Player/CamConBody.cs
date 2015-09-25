using UnityEngine;
using System.Collections;

public class CamConBody : MonoBehaviour {
	public float speed;
	public Vector3 rotatieAs;
	public float forDisRay;
	public float sideDisRay;
	public int moveSpeed;
	public Transform target;

	void Update () {
		Movement();
	//	CameraController();
	}
	/*void CameraController() {
		Vector3 relativePos = (target.position + new Vector3(0, 1.5f, 0)) - transform.position;
		Quaternion rotation = Quaternion.LookRotation(relativePos);

		Quaternion currect = Camera.main.transform.localRotation;
			
		Quaternion rotAs = Quaternion.Slerp(currect,rotation, Time.deltaTime);
		//rotatieAs.y = Input.GetAxis("Mouse X");
		//transform.Rotate(rotatieAs * speed * Time.deltaTime);
		transform.Translate(0, 0, 1 * Time.deltaTime);
	}*/

	void Movement (){
		rotatieAs.y = Input.GetAxis ("Mouse X");
		transform.Rotate (rotatieAs * speed * Time.deltaTime);
		if (Input.GetAxis ("Vertical") > 0) {	//forward
			if(!Physics.Raycast(transform.position,transform.forward,forDisRay)){
				transform.Translate(transform.forward*moveSpeed*Time.deltaTime);
			}	
		}
		if (Input.GetAxis ("Vertical") < 0) {	//backward
			if(!Physics.Raycast(transform.position,-transform.forward,forDisRay)){
				transform.Translate(-transform.forward*moveSpeed*Time.deltaTime);	
			}
		}
		if (Input.GetAxis ("Horizontal") > 0) {	//right
			if(!Physics.Raycast(transform.position,transform.right,sideDisRay)){
				transform.Translate(transform.right*moveSpeed*Time.deltaTime);
			}
		}
		if (Input.GetAxis ("Horizontal") < 0) {	//left
			if(!Physics.Raycast(transform.position,-transform.right,sideDisRay)){
				transform.Translate(-transform.right*moveSpeed*Time.deltaTime);
			}
		}
	}
}