using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bird : MonoBehaviour {

	// Use this for initialization
	public float		force_up;
	public float		force_fall;
	public GameObject	pipe_up;
	public GameObject	pipe_down;
	public anime		anime;

	private	float		time;
	/* 
	Rigidbody2D			rigidbody;
	Quaternion			downRot;
	Quaternion			forwardRot;
	public	float		tiltSmooth = 5;
	public	float		tapForce = 10;
	*/
//	private	int			score;
	void Start () {
		anime = pipe_up.GetComponent<anime>();

/*
		rigidbody = GetComponent<Rigidbody2D>();
		downRot = Quaternion.Euler(0, 0, -90);
		forwardRot = Quaternion.Euler(0, 0, 35);
*/
	}
	
	// Update is called once per frame
	void Update () {
		time += Time.deltaTime;
		transform.Translate(new Vector3(0, force_fall, 0));
		if (Input.GetKeyDown("space"))
		{
			transform.Translate(new Vector3(0, force_up, 0));
			Debug.Log ("Score: " + anime.score);
			//Debug.Log ("speed: " + anime.speed);
			/*transform.rotation = forwardRot;
			rigidbody.velocity = Vector3.zero;
			rigidbody.AddForce(Vector2.up * tapForce, ForceMode2D.Force);*/
		}
		/*
		Debug.Log(transform.rotation);
		transform.rotation = Quaternion.Lerp(transform.rotation, downRot, tiltSmooth * Time.deltaTime);
		Debug.Log(transform.rotation);*/
		//transform.rotation = downRot;
	}

	void OnTriggerEnter2D(Collider2D coll) {
		Debug.Log ("Score: " + anime.score);
		Debug.Log ("Time: " + Mathf.RoundToInt(time)+"s");
		Destroy(this);
	}
}
