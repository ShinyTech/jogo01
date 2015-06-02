using UnityEngine;
using System.Collections;

public class mov : MonoBehaviour {
	public float moveSpeed;

	private CharacterController controller ;
	
	private Vector3 moveDirection = Vector3.zero;
	private Vector3 forward = Vector3.zero;
	private Vector3 right = Vector3.zero;
	//private Rigidbody rb;

	// Use this for initialization
	void Start () {
		moveSpeed = 10f;
		//controller = GameObject.GetComponent(CharacterController);
		//rb = GetComponent<Rigidbody>();
	}


	// Update is called once per frame
	void Update () {
		/*
		forward = transform.forward;
		right = Vector3(forward.z, 0, -forward.x);
		
		var horizontalInput = Input.GetAxisRaw("Horizontal");
		var verticalInput = Input.GetAxisRaw("Vertical");

		var targetDirection = horizontalInput * right + verticalInput * forward;	
		
		moveDirection = Vector3.RotateTowards(moveDirection, targetDirection, 200 * Mathf.Deg2Rad * Time.deltaTime, 1000);
		
		var movement = moveDirection  * Time.deltaTime * 2;

		*/
		//Vector3 movement = new Vector3 (moveHorizontal, 0.0f, moveVertical);
		if (Input.GetKeyDown (KeyCode.LeftControl) == true) {
			transform.Rotate (new Vector3 (0, 90));
			//controller.Move(movement);
		} else if (Input.GetKeyDown (KeyCode.RightControl) == true) {
			transform.Rotate (new Vector3 (0, -90));
			//controller.Move(movement);
		} else {
			transform.Translate (moveSpeed * Input.GetAxis ("Horizontal") * Time.deltaTime, 0f, moveSpeed * Input.GetAxis ("Vertical") * Time.deltaTime);
		}

		//rb.AddForce (movement * moveSpeed);
	}
}








