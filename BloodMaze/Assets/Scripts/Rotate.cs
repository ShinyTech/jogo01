using UnityEngine;
using System.Collections;

public class Rotate : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		if (Input.GetKeyDown(KeyCode.LeftControl) == true) {
			transform.Rotate(new Vector3(0, 90));
		}
		if (Input.GetKeyDown(KeyCode.RightControl) == true) {
			transform.Rotate(new Vector3(0, -90));
		}
	
	}

}
