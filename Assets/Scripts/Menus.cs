using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Menus : MonoBehaviour {

	public void RestartLevel(){
		Application.LoadLevel (Application.loadedLevel);
	}

	public void Play(){
		Application.LoadLevel ("GameScene");
	}

	public void About(){
		Application.LoadLevel ("About");
	}

	public void Exit(){
		Application.Quit ();
	}

	public void Back(){
		Application.LoadLevel ("MenuScene");
	}
}
