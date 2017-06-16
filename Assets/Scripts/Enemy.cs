using UnityEngine;
using System.Collections;

public class Enemy : MonoBehaviour {

	void OnCollisionEnter(Collision col){
		if (col.gameObject.name == "Player") {
			Destroy (col.gameObject);
		}
	}
}
