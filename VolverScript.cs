using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VolverScript : MonoBehaviour {

	void Start ()
	{
		
	}

	public void VOLVER()
	{
		if (GameObject.FindGameObjectWithTag ("Carrera"))
			SolScript.clicked = 2;

		if (GameObject.FindGameObjectWithTag ("Defenza"))
			SolScript.clicked = 3;

		if (GameObject.FindGameObjectWithTag ("Formas"))
			SolScript.clicked = 4;

		if (GameObject.FindGameObjectWithTag ("Laberinto"))
			SolScript.clicked = 5;

		if (GameObject.FindGameObjectWithTag ("RPG"))
			SolScript.clicked = 7;

		if (GameObject.FindGameObjectWithTag ("Shooter"))
			SolScript.clicked = 6;

		if (GameObject.FindGameObjectWithTag ("Snake"))
			SolScript.clicked = 1;
	}
	
	void Update () 
	{
		
	}
}
