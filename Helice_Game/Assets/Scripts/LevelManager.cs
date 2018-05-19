using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManager : MonoBehaviour {
	public static int levelIndex=-1;
	public static bool isAlive=true;
	private static LevelManager levelManager;
	public static bool levelFinish=false;
	public static Sprite heliceSprite;
	public static int indexHelice=0;
	public static Sprite joystickSprite;
	public static int indexJoystick=0;
	void Awake()
	{
		if (levelManager == null) {
			levelManager = this;
			DontDestroyOnLoad (gameObject);
		} else {
			Destroy (gameObject);
		}
	}
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
