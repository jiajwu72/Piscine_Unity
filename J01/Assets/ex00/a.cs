using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class a : MonoBehaviour {

	public Sprite newSp;

	// Use this for initialization
	void Start () {
		Physics2D.gravity = new Vector2(5, 0);
		GameObject.fin
	}
	
	// Update is called once per frame

/*
	void Update () {
		//gameObject.GetComponent<SpriteRenderer>().sprite = newSp;
	}
*/

	void OnTriggerEnter2D(Collider2D coll) {
		Debug.Log("boom");
		gameObject.GetComponent<SpriteRenderer>().sprite = newSp;
	}
	
}
