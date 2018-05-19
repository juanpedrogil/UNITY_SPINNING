using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectJoystick : MonoBehaviour {
	public GameObject select;
	public int index;
	public Sprite joystickSprite;
	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {
		if (LevelManager.indexJoystick == index) {
			select.SetActive (true);
		} else {
			select.SetActive (false);
		}
	}
	public void selectThis(){
		LevelManager.indexJoystick = index;
		LevelManager.joystickSprite = joystickSprite;
	}
}
