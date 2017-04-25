using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RPGNivelCompleto : MonoBehaviour {

	public int NivelCompleto;

	void Start ()
	{
	}
	void Update ()
	{
		if (GameObject.Find ("RPGPlayer") != null)
		{
			NivelCompleto = GameObject.Find ("RPGPlayer").GetComponent<RpgPlayerMainScript> ().NivelCompleto;
		}
		if (GameObject.Find ("RPGPlayer") == null)
		{
			NivelCompleto = -1;
		}
	}
}
