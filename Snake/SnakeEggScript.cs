using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SnakeEggScript : MonoBehaviour {

	public float tempx = 0;
	public float tempy = 0;

	void Start ()
	{
		tempx = Random.Range (-3.20f, 3.20f);
		tempy = Random.Range (-3.20f, 3.20f);

		transform.SetParent (GameObject.FindGameObjectWithTag ("Snake").transform.GetChild (0));
	}

	void OnTriggerEnter2D (Collider2D other)
	{
		tempx = Random.Range (-3.20f, 3.20f);
		tempy = Random.Range (-3.20f, 3.20f);	
	}
	void Update () 
	{
			transform.position = new Vector3 (tempx, tempy, transform.position.z);	

	}
}
