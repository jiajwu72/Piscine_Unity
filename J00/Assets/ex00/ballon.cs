using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ballon : MonoBehaviour {

	public int jauge;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		//jauge--;
		if (Input.GetKeyDown ("space") && jauge < 6)
		{
			Debug.Log("space\n");
			transform.localScale = new Vector3(transform.localScale[0] + 0.1f, transform.localScale[1] + 0.1f, transform.localScale[2] + 0.1f);
			jauge++;
		}
		if ((Mathf.RoundToInt(10.0f * Time.realtimeSinceStartup) % 15) == 0)
		{
			if (jauge > 0) 
				jauge--;
			Debug.Log("jauge:" + jauge);
		} 
		transform.localScale = new Vector3(transform.localScale[0] - 0.005f, transform.localScale[1] - 0.005f, transform.localScale[2] - 0.005f);
		if (transform.localScale[0] < 0.5 || transform.localScale[1] < 0.5 || transform.localScale[2] < 0.5
											|| transform.localScale[0] > 2.5 || transform.localScale[1] > 2.5 || transform.localScale[2] > 2.5)
		{
			GameObject.Destroy(this);
			Debug.Log("Ballon life time : " + Mathf.RoundToInt(Time.realtimeSinceStartup));
		}
		
	}
}
