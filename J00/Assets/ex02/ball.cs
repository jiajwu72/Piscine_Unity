using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ball : MonoBehaviour {
	public bool		move;
	public float	speed;

	// Use this for initialization
	void Start () {
		move = false;
	}
	
	// Update is called once per frame
	void Update () {
		if (move)
		{
			transform.Translate(new Vector2(0, 0.01f * speed));
			if (speed > 0)
				speed -= 0.012f;
			else if (speed < 0)
				speed += 0.012f;
			if (speed < 0.1f && speed > -0.1f)
				move = false;
			if (transform.position.y > 2.9f || transform.position.y < -1.08f)
				speed *= -1;
		}
	}
}
