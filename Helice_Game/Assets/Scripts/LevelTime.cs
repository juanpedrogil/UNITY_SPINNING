using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LevelTime : MonoBehaviour {
	public Text time;
	int timeSeconds;
	// Use this for initialization
	void Start () {
		timeSeconds=LevelManager.levelTime;
		time=(Text)gameObject.GetComponent("Text");
		time.text=timeSeconds+"";
		Invoke("runningOut",1f);
	}
	void runningOut(){
		//Make the time running out
		if(LevelManager.startTime && !time.text.Equals("0")){
			time.text=int.Parse(time.text)-1+"";
		}
		if(int.Parse(time.text)<6){
			time.color=Color.red;
		}else{
			time.color=Color.white;
		}
		if(LevelManager.startTime && time.text.Equals("0") && LevelManager.isAlive){
			GameObject.FindObjectOfType<Helice>().die();
		}
		Invoke("runningOut",1f);
	}
	public void reset(){
		time.text=timeSeconds+"";
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
