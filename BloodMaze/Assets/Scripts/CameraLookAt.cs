using UnityEngine;
using System.Collections;

public class CameraLookAt : MonoBehaviour {
	public GameObject target;
	
	void LateUpdate() {
		transform.LookAt(target.transform);
	}
}
