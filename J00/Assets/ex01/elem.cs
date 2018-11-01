using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class elem : MonoBehaviour {

	public float	vitesse;
	// Use this for initialization
	void Start () {
		vitesse = Random.Range(-0.05f, -0.1f);
	}
	
	// Update is called once per frame
	void Update () {
		//Debug.Log("vitesse:" + vitesse + "\n");
		transform.Translate(new Vector3(0, vitesse, 0));
		if (transform.position[1] < -5)
		{
			//Debug.Log("destroy");
			//GameObject.Destroy(this);
			//Destroy(this);
		}
	}
}
