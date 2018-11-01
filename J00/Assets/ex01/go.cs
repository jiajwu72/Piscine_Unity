using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class go : MonoBehaviour {

	public	GameObject prefab;
	private	GameObject st;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (st && st.transform.position.y < -5)
		{
			Destroy(st);
		}
		if (!st && prefab)
			st = GameObject.Instantiate(prefab, prefab.transform.position, Quaternion.identity);
		if (Input.GetKeyDown ("a") && prefab.name == "a")
		{
			Debug.Log ("Precision: "+(st.transform.position.y + 4.651));
			Destroy(st);
		}
		if (Input.GetKeyDown ("s") && prefab.name == "s")
		{
			Debug.Log ("Precision: "+(st.transform.position.y + 4.651));
			Destroy(st);
		}
		if (Input.GetKeyDown ("d") && prefab.name == "d")
		{
			Debug.Log ("Precision: "+(st.transform.position.y + 4.651));
			Destroy(st);
		}
		Debug.Log("prefab: " + prefab.name);
	}
}
