using UnityEngine;
using System.Collections;

public class CameraController : MonoBehaviour {
	
	public GameObject personagem;
	
	private Vector3 offset;
	
	void Start ()
	{
		offset = transform.position - personagem.transform.position;
	}
	
	void Update ()
	{
		transform.position = personagem.transform.position + offset;
	}
}
