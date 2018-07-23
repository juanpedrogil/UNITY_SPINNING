using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Goal : MonoBehaviour {
	// Use this for initialization
	void Start () {
		GetComponent<Transform>().tag="GOAL";//Para que no muestre la explosión al momento de cruzar la meta
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	void OnTriggerEnter2D(Collider2D collider){
		//LevelManager.levelIndex++;
		//SceneManager.LoadScene ("GameScene");
		LevelManager.levelFinish=true;
		LevelManager.isAlive = false;
	}
}
