using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Joystick : MonoBehaviour {

	// Use this for initialization
	void Start () {
		if(LevelManager.indexJoystick!=0){
			GetComponent<Image> ().sprite=LevelManager.joystickSprite;
		}
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
