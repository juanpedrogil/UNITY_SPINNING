using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Helice : MonoBehaviour {
    private Rigidbody2D body;
	public GameObject player;
	private GameObject helice;
    private Vector3 moveVector;
    public int speed;
	public GameObject explosion;
    public VirtualJoystick joystick;
	// Use this for initialization
	void Start () {
		helice = GameObject.FindGameObjectWithTag ("Player");
        body = GetComponent<Rigidbody2D>();
		if(LevelManager.indexHelice!=0)helice.GetComponent<SpriteRenderer>().sprite = LevelManager.heliceSprite;
	}
	
	// Update is called once per frame
	void Update () {
		if (LevelManager.isAlive) {
			moveVector.x = joystick.Horizontal () * speed;
			moveVector.y = joystick.Vertical () * speed;
			//body.AddForce(moveVector*speed);
		} else {
			moveVector = Vector3.zero;
		}
		body.velocity = moveVector;
	}
	void OnCollisionEnter2D(Collision2D collision){
		helice.SetActive (false);
		LevelManager.isAlive = false;
		Vector3 position = helice.GetComponent<Transform>().position;
		Instantiate (explosion,new Vector3(position.x,position.y,-2.2f),Quaternion.identity);
		Invoke ("reCreate",2f);
	}
	void reCreate(){
		LevelManager.isAlive = true;
		Destroy (GameObject.FindGameObjectWithTag ("explosion"));
		helice.SetActive (true);
		player.GetComponent<Transform>().position = new Vector3 (0f,0f,90f);
	}
		
}
