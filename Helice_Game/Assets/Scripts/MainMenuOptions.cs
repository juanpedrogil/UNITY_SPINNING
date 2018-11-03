using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuOptions : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	public void start_click(){
		//SceneManager.LoadScene ("GameScene");
		LevelManager.sceneIndex=1;
		LevelManager.changeScene=true;
		LevelManager aux=GameObject.FindObjectOfType<LevelManager>();
		aux.saveConfig(LevelManager.sound,LevelManager.music);
	}
}
