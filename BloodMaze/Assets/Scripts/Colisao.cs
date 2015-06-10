using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Colisao : MonoBehaviour {

	public Text wPointsText;
	public int wpoints;

	void Start(){

	}

	void OnCollisionEnter(Collision collision) {
		Debug.Log ("Colidiu, " + collision.gameObject.tag.ToString());
		if (collision.gameObject.tag=="portalfinal") {
			int i = Application.loadedLevel;
			if (i == Application.levelCount - 2)
				Application.LoadLevel ("sobre");
			else
				Application.LoadLevel (i + 1);
		}
		if (collision.gameObject.CompareTag ("Coletaveis")) 
		{
			collision.gameObject.SetActive(false);
			Destroy(collision.gameObject);
			wpoints =wpoints+1;
			wPointsText.text = "Sangue Coletado: " + wpoints.ToString () + "/3";
			Debug.Log(collision.gameObject.tag.ToString());
			Debug.Log(wpoints);
		}
	}
}
