using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Hearts : MonoBehaviour {
	public GameObject gameOver;//Show the menu when there's not hearts anymore
	// Use this for initialization
	void Start () {
		refreshHearts();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	public void refreshHearts(){
		this.GetComponent<Text>().text=LevelManager.hearts+"";
		if(LevelManager.hearts==0 && !LevelManager.mainScene){
			LevelManager.mainScene=true;
			LevelManager.levelFinish = false;
			LevelManager.isAlive = true;
			gameOver.SetActive(true);
		}
	}
}
