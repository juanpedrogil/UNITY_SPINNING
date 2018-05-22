using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FadeEffect : MonoBehaviour {
	public Animator animator;
	public int sceneIndex;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if(LevelManager.changeScene){
			fadeIn();
		}
	}
	public void fadeIn(){
		sceneIndex=LevelManager.sceneIndex;
		LevelManager.changeScene=false;
		animator.SetTrigger("flag");
	}
	public void loadScene(){
		SceneManager.LoadScene(LevelManager.sceneIndex);
	}

}
