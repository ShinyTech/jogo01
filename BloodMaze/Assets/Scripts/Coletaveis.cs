using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Coletaveis : MonoBehaviour {

	public Text wPointsText;
	public GameObject wportalfinal;
	public int wpoints;
	// Use this for initialization
	void Start (){
		wpoints = 0;
		wportalfinal=GameObject.Find("PortalFinal");
		wportalfinal.SetActive (false);
	}

	//Faz objetos com tag coletaveis desaparecer
	void OnTriggerEnter(Collider other) 
	{
		if (other.gameObject.CompareTag ("Coletaveis")) 
		{
			other.gameObject.SetActive(false);
			Destroy(other.gameObject);
			wpoints =wpoints+1;
			wPointsText.text = "Sangue Coletado: " + wpoints.ToString () + "/3";
			if (wpoints>=3){
				wportalfinal.SetActive(true);
			}
			//Debug.Log(other.gameObject.tag.ToString());
			//Debug.Log(wpoints);
		}
	}

}
