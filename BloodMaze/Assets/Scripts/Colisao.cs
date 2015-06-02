using UnityEngine;
using System.Collections;

public class Colisao : MonoBehaviour {
	public Transform explosionPrefab;
	
	void OnCollisionEnter(Collision collision) {
		int i = Application.loadedLevel;
		Application.LoadLevel(i - 1);
	}
}
