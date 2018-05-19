using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectHelice : MonoBehaviour {
	public GameObject select;
	public int index;
	public Sprite heliceSprite;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (LevelManager.indexHelice == index) {
			select.SetActive (true);
		} else {
			select.SetActive (false);
		}
	}
	public void selectThis(){
		LevelManager.indexHelice = index;
		LevelManager.heliceSprite = heliceSprite;
	}
}
