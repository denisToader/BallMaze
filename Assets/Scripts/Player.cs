using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {

	public int speed = 20;
	public bool isFlat = true;
	private Rigidbody rigid;
	private AudioSource source;

	private void Awake(){
		source = GetComponent<AudioSource> ();
		Screen.sleepTimeout = SleepTimeout.NeverSleep;
	}

	private void Start () {
		rigid = GetComponent<Rigidbody> ();
		rigid.constraints = RigidbodyConstraints.FreezePositionY;
	}

	private void Update() {
		Vector3 tilt = Input.acceleration * speed;
		Debug.Log(tilt);

		if (isFlat)
			tilt = Quaternion.Euler (90, 0, 0) * tilt;

		rigid.AddForce(tilt);
		Debug.DrawRay(transform.position + Vector3.up, tilt, Color.cyan);
	}

	void OnCollisionEnter(Collision col){
		if (col.gameObject.tag == "Enemy") {
			source.Play();
			Application.LoadLevel (Application.loadedLevel);
		}
	}
}
