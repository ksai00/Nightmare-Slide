using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ballmovement : MonoBehaviour {

	Rigidbody ourrigidbody;
	public float velocity;
	public float jumpforce;
	public float slidespeed = 2;
	float time;
	public static int timer;
	public Text timetext;
	// Use this for initialization
	void Start () {
		ourrigidbody = GetComponent<Rigidbody> ();
	}

	// Update is called once per frame
	void Update () {
			ourrigidbody.velocity = Vector3.down*slidespeed;
		if (Input.GetKey (KeyCode.W)) {
			ourrigidbody.velocity += velocity * Vector3.forward;
		}
		if (Input.GetKey (KeyCode.A)) {
			ourrigidbody.velocity += velocity * Vector3.left;
		}
		if (Input.GetKey (KeyCode.S)) {
			ourrigidbody.velocity += velocity * Vector3.up;
		}
		if (Input.GetKey (KeyCode.D)) {
			ourrigidbody.velocity += velocity * Vector3.right;
		}
			
		if (Input.GetKeyDown (KeyCode.Space)) {
			ourrigidbody.AddForce (Vector3.up * jumpforce);
			StartCoroutine (jumproutine());
		}
		if (gameObject.tag == "Player"&& Input.GetKeyDown(KeyCode.Space)) {
			ourrigidbody.AddForce (jumpforce * Vector3.up);
		}
		time += Time.deltaTime;
		timer = (int)time;
		timetext.text = timer.ToString();
	}

	IEnumerator jumproutine(){
		float jumpnum = jumpforce;
		yield return 0;
		for(int i=0; i<20;i++){
			ourrigidbody.velocity += (jumpnum * Vector3.up);
			jumpnum--;
			yield return 0;
		}
	}
}
