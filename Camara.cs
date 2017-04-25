using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camara : MonoBehaviour {

	private float tamaño;

	void Start ()
	{
		tamaño = 5.5f;
		Screen.SetResolution (800, 600, false);
	}
	void Update()
	{
		Screen.SetResolution (800, 600, false);
		gameObject.GetComponent<Camera>().orthographicSize=tamaño;
		if (GameObject.Find ("Pista1(Clone)"))
		{
			tamaño = 3.25f;
		}
		else if (GameObject.Find ("Pista2(Clone)"))
		{
			tamaño = 3.6f;
		}
		else if (GameObject.Find ("Pista3(Clone)"))
		{
			tamaño = 3.1f;
		}
		else if (GameObject.Find ("Pista4(Clone)"))
		{
			tamaño = 3.6f;
		}
		else if (GameObject.Find ("Pista5(Clone)"))
		{
			tamaño = 3.6f;
		}
		else if (GameObject.Find ("DefenzaNivel1(Clone)"))
		{
			tamaño = 4.3f;
		}
		else if (GameObject.Find ("DefenzaNivel2(Clone)"))
		{
			tamaño = 4.3f;
		}
		else if (GameObject.Find ("DefenzaNivel3(Clone)"))
		{
			tamaño = 4.3f;
		}
		else if (GameObject.Find ("DefenzaNivel4(Clone)"))
		{
			tamaño = 4.3f;
		}
		else if (GameObject.Find ("DefenzaNivel5(Clone)"))
		{
			tamaño = 4.3f;
		}
		else if (GameObject.Find ("FormasNivel1(Clone)"))
		{
			tamaño = 2.7f;
		}
		else if (GameObject.Find ("FormasNivel2(Clone)"))
		{
			tamaño = 2.7f;
		}
		else if (GameObject.Find ("FormasNivel3(Clone)"))
		{
			tamaño = 2.7f;
		}
		else if (GameObject.Find ("FormasNivel4(Clone)"))
		{
			tamaño = 2.7f;
		}
		else if (GameObject.Find ("FormasNivel5(Clone)"))
		{
			tamaño = 2.7f;
		}
		else if (GameObject.Find ("Laberinto1(Clone)"))
		{
			tamaño = 2.7f;
		}
		else if (GameObject.Find ("Laberinto2(Clone)"))
		{
			tamaño = 2.7f;
		}
		else if (GameObject.Find ("Laberinto3(Clone)"))
		{
			tamaño = 2.7f;
		}
		else if (GameObject.Find ("Laberinto4(Clone)"))
		{
			tamaño = 2.7f;
		}
		else if (GameObject.Find ("Laberinto5(Clone)"))
		{
			tamaño = 2.7f;
		}
		else if (GameObject.Find ("RPGPlanet1(Clone)"))
		{
			tamaño = 5.5f;
		}
		else if (GameObject.Find ("RPGPlanet2(Clone)"))
		{
			tamaño = 4.8f;
		}
		else if (GameObject.Find ("RPGPlanet3(Clone)"))
		{
			tamaño = 4.8f;
		}
		else if (GameObject.Find ("RPGPlanet4(Clone)"))
		{
			tamaño = 4.8f;
		}
		else if (GameObject.Find ("RPGPlanet5(Clone)"))
		{
			tamaño = 5.5f;
		}
		else if (GameObject.Find ("ShooterNivel1(Clone)"))
		{
			tamaño = 5.5f;
		}
		else if (GameObject.Find ("ShooterNivel2(Clone)"))
		{
			tamaño = 5.5f;
		}
		else if (GameObject.Find ("ShooterNivel3(Clone)"))
		{
			tamaño = 5.5f;
		}
		else if (GameObject.Find ("ShooterNivel4(Clone)"))
		{
			tamaño = 5.5f;
		}
		else if (GameObject.Find ("ShooterNivel5(Clone)"))
		{
			tamaño = 5.5f;
		}
		else if (GameObject.Find ("SnakePlanet1(Clone)"))
		{
			tamaño = 4.4f;
		}
		else if (GameObject.Find ("SnakePlanet2(Clone)"))
		{
			tamaño = 4.4f;
		}
		else if (GameObject.Find ("SnakePlanet3(Clone)"))
		{
			tamaño = 4.4f;
		}
		else if (GameObject.Find ("SnakePlanet4(Clone)"))
		{
			tamaño = 5.2f;
		}
		else if (GameObject.Find ("SnakePlanet5(Clone)"))
		{
			tamaño = 4.4f;
		}
		else
		{
			tamaño = 5.5f;
		}
	}
}
