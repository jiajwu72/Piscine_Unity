using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class anime : MonoBehaviour {

	// Use this for initialization
	private	float	speed;
	public	int		score;
	private	int		last_score;
	//private	bool	speed_up;
	//public	GameObject bird;

	void Start () {
		speed = -0.02f;
		score = 0;
		last_score = 0;
		//speed_up = false;
	}
	
	// Update is called once per frame
	void Update () {
		if (last_score < score && score % 4 == 0 && speed > -0.05f)
		{
			speed += -0.005f;
			Debug.Log("speed : " + speed);
			last_score = score;
		}
		transform.Translate(new Vector2(speed, 0));
		if ((this.name == "pipe_down" || this.name == "pipe_up") && transform.position.x < -3f)
		{
			score += 1;
			transform.Translate(new Vector2(7f, 0));
			transform.localScale = new Vector2(transform.localScale[0], Random.Range(0.36f, 0.50f));
		}
		
		if ((this.name == "background" || this.name == "ground" || this.name == "background (1)" || this.name == "ground (1)") 
			&& transform.position.x < -8)
		{
			transform.Translate(new Vector2(16f, 0));
		}

	}
}
