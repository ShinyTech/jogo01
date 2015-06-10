using UnityEngine;
using System.Collections;
[RequireComponent(typeof(Rigidbody))]

public class mov : MonoBehaviour {
	
	public float movementSpeed = 10;
	public float turningSpeed = 60;
	private Rigidbody rb;

	void Start(){
		rb = GetComponent<Rigidbody>();
	}

	void Update() {
		float horizontal = Input.GetAxis("Horizontal") * turningSpeed * Time.deltaTime;
		transform.Rotate(0, horizontal, 0);
		
		float vertical = Input.GetAxis("Vertical") * movementSpeed * Time.deltaTime;
		transform.Translate(0, 0, vertical);
	}

	void OnCollisionEnter(Collision collision) 
	{
		if(collision.gameObject.name == "cenario")  // or if(gameObject.CompareTag("YourWallTag"))
		{
			rb.velocity = Vector3.zero;
			rb.transform.Rotate(0, 0, 0);
			rb.transform.Translate(0,0,0);
		}
	}

}








