using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level1 : MonoBehaviour {
	public GameObject[] levels;
	// Use this for initialization

	void Start () {
		Instantiate (levels[LevelManager.levelIndex],new Vector3(0f,0f,0f),Quaternion.identity);
	}
}
