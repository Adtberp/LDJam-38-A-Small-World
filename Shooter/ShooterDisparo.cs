using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShooterDisparo : MonoBehaviour {

	private GameObject[] Enemigos;

	void Start ()
	{
		Destroy (gameObject, 2);
	}
	void FixedUpdate ()
	{
		transform.Translate (3 * Time.deltaTime, 0, 0, Space.Self);
	}
}