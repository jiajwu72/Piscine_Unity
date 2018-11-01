using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour {

	// Use this for initialization
	public	float		speed;
	public	Vector2		dir;
	public	Rigidbody2D	rb2;
	int					score_p1;
	int					score_p2;

	void Start () {
		dir = new Vector2(Random.Range(-0.8f, 0.8f), Random.Range(-0.8f, 0.8f));
		rb2 = GetComponent<Rigidbody2D>();
		score_p1 = 0;
		score_p2 = 0;
		//dir = Vector2.one.normalized;
		//radius = transform.localScale.x / 2;
	}
	
	// Update is called once per frame
	void Update () {

		rb2.velocity = dir * speed * Time.deltaTime;
		if (transform.position.y < -3f && dir.y < 0f)
			dir.y = -dir.y;
		else if (transform.position.y > 3f && dir.y > 0f)
			dir.y = -dir.y;
		if (transform.position.x < -5.22f)
		{
			score_p2 ++;
			transform.position = Vector2.zero;
			//Thread.Sleep(2000);
			Debug.Log(score_p1 + ":" + score_p2);
		}
		else if (transform.position.x > 5.22f)
		{
			score_p1 ++;
			transform.position = Vector2.zero;
			//Thread.Sleep(2000);
			Debug.Log(score_p1 + ":" + score_p2);
		}

	}
	void OnTriggerEnter2D(Collider2D coll) {
		//Debug.Log("boom");
		//if (touch)
		dir.x = -dir.x;
	}
}
