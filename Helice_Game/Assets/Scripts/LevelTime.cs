using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LevelTime : MonoBehaviour {
	public Text time;
	int timeSeconds;
	// Use this for initialization
	void Start () {
		timeSeconds=120;
		time=(Text)gameObject.GetComponent("Text");
		time.text=timeSeconds+"";
		Invoke("runningOut",1f);
	}
	void runningOut(){
		//Make the time running out
		Debug.Log(LevelManager.startTime);
		if(LevelManager.startTime && time.text.Equals("0") && LevelManager.isAlive){
			GameObject.FindObjectOfType<Helice>().die();
		}
		if(LevelManager.startTime && !time.text.Equals("0")){
			time.text=int.Parse(time.text)-1+"";
		}
		if(int.Parse(time.text)<6){
			time.color=Color.red;
		}else{
			time.color=Color.white;
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
