using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level1 : MonoBehaviour {
	public GameObject[] levels;
	// Use this for initialization

	void Start () {
		switch (LevelManager.levelIndex) {
		case 0:
			level1 ();
			break;
		case 1:
			level2 ();
			break;
		case 2:
			level3 ();
			break;
		case 3:
			level4 ();
			break;
		case 4:
			level5 ();
			break;
		case 5:
			level6 ();
			break;
		case 6:
			level7 ();
			break;
		case 7:
			level8 ();
			break;
		case 8:
			level9 ();
			break;
		}
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	void level1(){
		Instantiate (levels[0],new Vector3(25.7f,-4.05f,0f),Quaternion.identity);
	}
	void level2(){
		Instantiate (levels[1],new Vector3(0f,0f,0f),Quaternion.identity);
	}
	void level3(){
		Instantiate (levels[2],new Vector3(6.0084f,-5.115758f,0f),Quaternion.identity);
	}
	void level4(){
		Instantiate (levels[3],new Vector3(0f,0f,0f),Quaternion.identity);
	}
	void level5(){
		Instantiate (levels[4],new Vector3(0f,0f,0f),Quaternion.identity);
	}
	void level6(){
		Instantiate (levels[5],new Vector3(0f,0f,0f),Quaternion.identity);
	}
	void level7(){
		Instantiate (levels[6],new Vector3(0f,0f,0f),Quaternion.identity);
	}
	void level8(){
		Instantiate (levels[7],new Vector3(0f,0f,0f),Quaternion.identity);
	}
	void level9(){
		Instantiate (levels[8],new Vector3(0f,0f,0f),Quaternion.identity);
	}

}
