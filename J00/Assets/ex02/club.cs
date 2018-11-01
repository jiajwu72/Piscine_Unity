using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class club : MonoBehaviour {

	// Use this for initialization
	private	int			score;
	private	float		jauge;
	private	ball		balle;
	private bool		hold;

	public	GameObject	gameObj_balle;

	void Start () {
		balle = gameObj_balle.GetComponent<ball>();
		hold = false;
		score = -15;
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown("space"))
		{
			jauge += 0f;
			hold = true;
		}
		else if (Input.GetKeyUp("space"))
		{
			//Debug.Log("key up\n");
			hold = false;
			balle.speed = jauge;
			balle.move = true;
			jauge = 0;
			Debug.Log("position:" + balle.transform.position);
			if (balle.transform.position.y >= 2.3f && balle.transform.position.y <= 2.45f)
			{
				Debug.Log("Yes!\nscore :" + score);
			}
			else
			{
				score += 5;
				Debug.Log("coup manque!\nscore :" + score);
			}
		}
		if (hold)
		{
			jauge += 0.04f;
			transform.Translate(new Vector2(0, -0.008f));
			//Debug.Log("jauge:" + jauge);
		}
		else if (!balle.move)
		{
			transform.position = balle.transform.position;
			transform.Translate(new Vector2(-0.06f, 0.13f));
			//Debug.Log("position:" + transform.position);
		}

	}
}
