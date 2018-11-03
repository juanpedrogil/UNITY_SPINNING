using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Helice_Manager : MonoBehaviour {
	public Sprite[] helices;
	public Sprite[] joysticks;
	public Slider volumenSlider,musicSlider;
	// Use this for initialization
	void Start () {
		putSprite(LevelManager.indexHelice);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	public void setSprites(int indexHelice,int indexJoystick){
		LevelManager.heliceSprite=helices[indexHelice];
		LevelManager.joystickSprite=joysticks[indexJoystick];
		putSprite(indexHelice);
	}
	public void putSprite(int indexHelice){
		if(this.GetComponent<SpriteRenderer>()!=null){
			this.GetComponent<SpriteRenderer>().sprite=helices[indexHelice];
		}
	}
}
