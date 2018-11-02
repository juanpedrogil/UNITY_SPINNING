using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
using System;

public class LevelManager : MonoBehaviour {
	public static int levelIndex=-1;
	public static bool isAlive=true;
	private static LevelManager levelManager;
	public static bool levelFinish=false;
	public static Sprite heliceSprite;
	public static int indexHelice=0;
	public static Sprite joystickSprite;
	public static int indexJoystick=0;
	public static int sceneIndex=0;
	public static int levelTime=0;
	public static bool changeScene=false;
	public static float sensibility=1;
	public static bool startTime=false;
	private GameObject heliceEX;
	public static float sound,music;


	//Configuration variables	
	
	private string configPath;
	void Awake()
	{
		configPath=Application.persistentDataPath+"/settings.conf";
		if (levelManager == null) {
			levelManager = this;
			DontDestroyOnLoad (gameObject);
		} else {
			Destroy (gameObject);
		}
	}
	// Use this for initialization
	void Start () {
		loadConfig();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	public void saveConfig(float sound,float music){
		//Save the configuration inside of an object and then serialize in the device storage
		BinaryFormatter bf=new BinaryFormatter();
		FileStream file=File.Create(configPath);
		Configuration configObject=new Configuration();
		configObject.sensibility=sensibility;
		configObject.levelIndex=levelIndex;
		configObject.indexHelice=indexHelice;
		configObject.indexJoystick=indexJoystick;
		configObject.sound=sound;
		configObject.music=music;
		bf.Serialize(file,configObject);
		file.Close();
		Helice_Manager options=GameObject.FindObjectOfType<Helice_Manager>();
		options.volumenSlider.value=configObject.sound;
		options.musicSlider.value=configObject.music;
		options.setSprites(indexHelice,indexJoystick);
	}
	void loadConfig(){
		//Open the configuration file the read and set all settings into application
		if(File.Exists(configPath)){

			BinaryFormatter bf=new BinaryFormatter();
			FileStream file=File.Open(configPath,FileMode.Open);
			Configuration configObject=(Configuration)bf.Deserialize(file);
			sensibility=configObject.sensibility;
			levelIndex=configObject.levelIndex;
			indexHelice=configObject.indexHelice;
			indexJoystick=configObject.indexJoystick;
			Helice_Manager options=GameObject.FindObjectOfType<Helice_Manager>();
			options.volumenSlider.value=configObject.sound;
			options.musicSlider.value=configObject.music;
			options.setSprites(indexHelice,indexJoystick);
			file.Close();
		}
	}
	void changeHeliceSprite(){
		if(heliceEX==null){
			heliceEX=GameObject.Find("HeliceEX");
		}
		heliceEX.GetComponent<SpriteRenderer>().sprite=heliceSprite;
	}
}
[Serializable]
class Configuration{
	public float sensibility;
	public float sound;
	public float music;
	public int levelIndex;
	public int indexHelice;
	public int indexJoystick;
}
