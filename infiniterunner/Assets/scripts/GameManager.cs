using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour {
	public static int score;
	public Text gameovertext;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKeyDown(KeyCode.J)){
			SceneManager.LoadScene ("infrunner");
			ballmovement.timer = 0;
			score = 0;
		}
		if (gameovertext != null) {
			gameovertext.text = ("Score: " + score.ToString());
		}
		
	}

	void OnTriggerEnter(Collider player){
		if (player.gameObject.tag == "Player") {
			score = ballmovement.timer;
			SceneManager.LoadScene ("gameover");
		}
	}
}
