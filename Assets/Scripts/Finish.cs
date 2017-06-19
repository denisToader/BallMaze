using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Finish : MonoBehaviour {

	private Scene currentScene;
	private string sceneName;
	private AudioSource source;

	private void Awake(){
		source = GetComponent<AudioSource> ();
	}

	void Start(){
		currentScene = SceneManager.GetActiveScene();

		sceneName = currentScene.name;
	}

	void OnCollisionEnter(Collision col){

		if (col.gameObject.name == "Player") {
			//Destroy (col.gameObject);
			if(sceneName == "GameScene")
				Application.LoadLevel ("GameScene2");
			if(sceneName == "GameScene2")
				Application.LoadLevel ("About");
			source.Play ();
		}
	}

}
