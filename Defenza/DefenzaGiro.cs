using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DefenzaGiro : MonoBehaviour {

	public int NivelCompleto;

	void Start ()
	{
	}
	
	void Update ()
	{
		if (GameObject.Find ("DefenzaNivel1(Clone)") != null && GameObject.FindWithTag ("Enemigo") == null)
		{
			NivelCompleto = 1;
		}
		else if (GameObject.Find ("DefenzaNivel2(Clone)") != null && GameObject.FindWithTag ("Enemigo") == null)
		{
			NivelCompleto = 2;
		}
		else if (GameObject.Find ("DefenzaNivel3(Clone)") != null && GameObject.FindWithTag ("Enemigo") == null)
		{
			NivelCompleto = 3;
		}
		else if (GameObject.Find ("DefenzaNivel4(Clone)") != null && GameObject.FindWithTag ("Enemigo") == null)
		{
			NivelCompleto = 4;
		}
		else if (GameObject.Find ("DefenzaNivel5(Clone)") != null && GameObject.FindWithTag ("Enemigo") == null)
		{
			NivelCompleto = 5;
		}
		if (gameObject.name == "DefenzaCentroArma")
		{
			if (Input.GetKey ("left"))
			{
				transform.Rotate (0, 0, +180 * Time.deltaTime, Space.Self);
			}
			if (Input.GetKey ("right"))
			{
				transform.Rotate (0, 0, -180 * Time.deltaTime, Space.Self);
			}
		}
	}
}
