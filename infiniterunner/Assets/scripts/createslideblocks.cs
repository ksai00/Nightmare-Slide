using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class createslideblocks : MonoBehaviour {
	public Transform[][] floorprefabarray;
	public Transform[] floor_prefabs;
	public Transform[] floor_prefabs1;
	public Transform[] floor_prefabs2;
	float pathlength = 25;
	public float steplength = 3.5f;
	int set = 0;
	Transform[] currentset;


	// Use this for initialization
	void Start () {

		
		
	}
	
	// Update is called once per frame
	void Update () {
		if (set <= 0) {
			currentset = floor_prefabs;
		}
		if (set == 1) {
			currentset = floor_prefabs1;
		}
		if (set >= 2) {
			currentset = floor_prefabs2;
		}

		if (pathlength > 0) {
			Instantiate (floor_prefabs [Random.Range (0, floor_prefabs.Length)], transform.position, Quaternion.Euler (45f, 0f, 0f));
	
			transform.position += new Vector3 (Random.value * 8f - 4f, -1f * steplength, steplength);
		} 
		else {
			set++;
			pathlength = 25f;

		}
		pathlength--;
		
	}
}
