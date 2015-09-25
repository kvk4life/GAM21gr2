using UnityEngine;
using System.Collections;

public class CamWallContr : MonoBehaviour {
	public	 	Transform 	ownTransform;
	private 	RaycastHit 	hit;
	public 		Transform 	target;
	public 		float 		distance;
	public 		float 		minVal;
	public 		float 		maxVal;
	private		float 		tarYPos;

	void FixedUpdate (){
		Vector3 dir = (target.position - ownTransform.position).normalized;
		if(Physics.Raycast(ownTransform.position, dir, out hit, distance)){
			target.position = hit.point;
		}
		else{
			target.position = ownTransform.position + dir * distance;
			tarYPos = target.position.y;
			float clampedPos = Mathf.Clamp(tarYPos,minVal,maxVal);
			tarYPos = clampedPos;
		}
	}
}