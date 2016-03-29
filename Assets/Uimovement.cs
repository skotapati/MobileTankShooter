using UnityEngine;
using System.Collections;

public class Uimovement : MonoBehaviour {
	public GameObject player;
	public int speed;

	// Use this for initialization
	void Start () {
	}

	void MoveForword(){
		transform.position += transform.forward*speed*Time.deltaTime;
	}
	
	// Update is called once per frame
	void Update () {
		gameObject.transform.LookAt (player.transform.position);
		MoveForword ();

	}
}
