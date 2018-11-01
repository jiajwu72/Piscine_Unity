using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pandle : MonoBehaviour {

	public	float	incre;
	float speed = 0.1f;

	private	bool	left;
	// Use this for initialization
	void Start () {
		if (this.name == "pandle_left")
			left = true;
		else
			left = false;
	}
	
	void Move(int side)
	{
		transform.position = (Vector2.right * transform.position.x) + Vector2.up * Mathf.Clamp(transform.position.y + (side * speed), -2.3f, 2.3f);
	}

	// Update is called once per frame
	void Update () {
		//Debug.Log(this.name);
		incre = 0;
		if (left)
		{
			if (Input.GetKey("w"))
				Move(1);
			else if (Input.GetKey("s"))
				Move(-1);
		}
		else// if (!left)
		{
			if (Input.GetKey("up"))
				Move(1);
			if (Input.GetKey("down"))
				Move(-1);
		}
	}
}
