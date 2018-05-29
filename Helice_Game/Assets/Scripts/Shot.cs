using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shot : MonoBehaviour {
	public GameObject explosion,bullet;
	private Vector3 position;
	// Use this for initialization
	void Start () {
		position = GetComponent<Transform>().position;
		shotTheBullet();
	}
	private void shotTheBullet(){
		Instantiate(explosion,position,Quaternion.identity);
		Instantiate(bullet,position,Quaternion.identity);
		Invoke("shotTheBullet",Random.Range(5f,20f));
	}
}
