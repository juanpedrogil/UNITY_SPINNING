using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour {
	public string direction;
	public float speed;
	private Rigidbody2D rb;
	private float velX,velY;
	// Use this for initialization
	void Start () {
		rb=GetComponent<Rigidbody2D>();
		velX=rb.velocity.x;
		velY=rb.velocity.y;
		switch(direction){
			case "up":moveUp();
				break;
			case "down":moveDown();
				break;
			case "left":moveLeft();
				break;
			case "right":moveRight();
				break;
		}
	}
	private void moveUp(){
		rb.velocity=new Vector2(velX,velY+speed);
	}
	private void moveDown(){
		rb.velocity=new Vector2(velX,velY-speed);
	}
	private void moveLeft(){
		rb.velocity=new Vector2(velX-speed,velY);
	}
	private void moveRight(){
		rb.velocity=new Vector2(velX+speed,velY);
	}

	
	// Update is called once per frame
	void Update () {
		
	}
	void OnCollisionEnter2D(Collision2D collision){
		Destroy(this.gameObject);
	}
}
