using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Helice_Manager : MonoBehaviour {
	public Sprite[] helices;
	public Sprite[] joysticks;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	public void setSprites(int indexHelice,int indexJoystick){
		LevelManager.heliceSprite=helices[indexHelice];
		LevelManager.joystickSprite=joysticks[indexJoystick];
	}
}
