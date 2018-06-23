using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

    public float speed;
    public Animator anim;
	public float moveSpeed = 10f;
	public float turnSpeed = 50f;

	// Use this for initialization
	void Start () {
		anim = GetComponent<Animator> ();
		anim.SetTrigger ("idle");
	}
	
	// Update is called once per frame
	void Update () {

		if (Input.GetKey (KeyCode.W)) {
			anim.SetTrigger ("moving");
			transform.Translate (Vector3.forward * moveSpeed * Time.deltaTime);
		}
		else if (Input.GetKey (KeyCode.S)) {
			transform.Translate (-Vector3.forward * moveSpeed * Time.deltaTime);
			anim.SetTrigger ("movingdown");
		}
		else if (Input.GetKey (KeyCode.A)) {
			transform.Rotate (Vector3.up, -turnSpeed * Time.deltaTime);
		}
		else if (Input.GetKey (KeyCode.D)) {
			transform.Rotate (Vector3.up, turnSpeed * Time.deltaTime);
		}
		else if (Input.GetButtonDown("Fire1")) {
			anim.SetTrigger ("Attack");
		} 
		else {
			anim.SetTrigger ("idle");	
		}
	


//        if (Input.GetKey(KeyCode.A))
//        {
//            transform.position -= transform.right * speed *Time.deltaTime;
//            
//        }
//
//        if (Input.GetKey(KeyCode.D))
//        {
//			transform.rotation = transform.rotation.eulerAngles;
//			anim.SetTrigger ("moving");
//            transform.position += transform.right * speed * Time.deltaTime;
//			transform.Translate(Vector3.for)
//        }
//
//        if (Input.GetKey(KeyCode.W))
//		{	
//			anim.SetTrigger ("moving");
//            transform.position += transform.forward * speed * Time.deltaTime;
//
//        }
//        if (Input.GetKey(KeyCode.S))
//        {
//            transform.position -= transform.forward * speed * Time.deltaTime;
//        }
//
//        if (Input.GetButtonDown("Fire1"))
//        {
//            anim.SetTrigger("Attack");
//        }

	}
}
