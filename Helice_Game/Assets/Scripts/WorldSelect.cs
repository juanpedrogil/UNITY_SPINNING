using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WorldSelect : MonoBehaviour {
	public GameObject canvas,me;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	public void turnOn(){
		canvas.SetActive (true);
		me.SetActive(false);
		if(canvas.name.Equals("Main Menu")){
			LevelManager aux=GameObject.FindObjectOfType<LevelManager>();
			aux.saveConfig(LevelManager.sound,LevelManager.music);
		}
	}
}
