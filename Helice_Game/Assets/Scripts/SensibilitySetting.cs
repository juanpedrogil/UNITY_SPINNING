using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SensibilitySetting : MonoBehaviour {
	public Slider sensibilitySlider,volumenSlider,musicSlider;
	public LevelManager lm;
	// Use this for initialization
	void Start () {
		sensibilitySlider.value=(LevelManager.sensibility);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	public void changeSensibility(){
		//When the slider value changes then the sensibility variable change +2
		LevelManager.sensibility=sensibilitySlider.value;
		Debug.Log(LevelManager.sensibility);
		lm.saveConfig(volumenSlider.value,musicSlider.value);
	}
}
