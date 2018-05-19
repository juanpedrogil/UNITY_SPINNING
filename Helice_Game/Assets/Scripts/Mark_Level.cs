using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mark_Level : MonoBehaviour {
	public GameObject preview;
	public int index;
	// Use this for initialization
	void Start () {
		if(LevelManager.levelIndex!=index)preview.SetActive (false);
	}
	
	// Update is called once per frame
	void Update () {
		if (LevelManager.levelIndex == index) {
			preview.SetActive (true);
		} else {
			preview.SetActive (false);
		}
	}
	public void click(){
		LevelManager.levelIndex = index;
	}
}
