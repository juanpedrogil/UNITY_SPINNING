using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Pause_Options : MonoBehaviour {
	public GameObject levelFinishUI;
	public GameObject helice;
	// Use this for initialization
	void Start () {
		levelFinishUI.SetActive(false);
	}
	
	// Update is called once per frame
	void Update () {
		if (LevelManager.levelFinish) {
			levelFinishUI.SetActive (true);
			helice.SetActive (false);
		} //else {
			//levelFinishUI.SetActive(false);
			////helice.SetActive (true);
		//}
	}
	public void restart(){
		LevelManager.levelFinish = false;
		LevelManager.isAlive = true;
		//SceneManager.LoadScene ("GameScene");
		LevelManager.changeScene=true;
		LevelManager.startTime=false;
		LevelTime aux=GameObject.FindObjectOfType<LevelTime>();
		aux.reset();
	}
	public void next(){
		LevelManager.levelIndex++;
		restart ();
	}
	public void home(){
		LevelManager.levelFinish = false;
		LevelManager.isAlive = true;
		//SceneManager.LoadScene ("MainMenu");
		LevelManager.sceneIndex=0;
		LevelManager.changeScene=true;
	}
}
