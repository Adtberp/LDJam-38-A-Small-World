using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlanetaScript : MonoBehaviour {

	public GameObject Planeta;
	private GameObject PlanInst;
	private float tamaño = 0.01f;
	private int seguro = 1;
	//private Vector3 startpos;

	void Start () 
	{
		//startpos = transform.position;
	}

	void OnMouseDown()
	{
		if (GameObject.Find ("MainController").GetComponent<MainControlScript> ().Snake == 0) {
			if (Planeta.name == "SnakePlanet1") {
				PlanInst = Instantiate (Planeta, transform.position, Planeta.transform.rotation);
				seguro = 2;
			}
		}
		if (GameObject.Find ("MainController").GetComponent<MainControlScript> ().Snake == 1) {
			if (Planeta.name == "SnakePlanet1" || Planeta.name == "SnakePlanet2") {
				PlanInst = Instantiate (Planeta, transform.position, Planeta.transform.rotation);
				seguro = 2;
			}
		}
		if (GameObject.Find ("MainController").GetComponent<MainControlScript> ().Snake == 2) {
			if (Planeta.name == "SnakePlanet1" || Planeta.name == "SnakePlanet2" || Planeta.name == "SnakePlanet3") {
				PlanInst = Instantiate (Planeta, transform.position, Planeta.transform.rotation);
				seguro = 2;
			}
		}
		if (GameObject.Find ("MainController").GetComponent<MainControlScript> ().Snake == 3) {
			if (Planeta.name == "SnakePlanet1" || Planeta.name == "SnakePlanet2" || Planeta.name == "SnakePlanet3" || Planeta.name == "SnakePlanet4") {
				PlanInst = Instantiate (Planeta, transform.position, Planeta.transform.rotation);
				seguro = 2;
			}
		}
		if (GameObject.Find ("MainController").GetComponent<MainControlScript> ().Snake == 4) {
			if (Planeta.name == "SnakePlanet1" || Planeta.name == "SnakePlanet2" || Planeta.name == "SnakePlanet3" || Planeta.name == "SnakePlanet4" || Planeta.name == "SnakePlanet5") {
				PlanInst = Instantiate (Planeta, transform.position, Planeta.transform.rotation);
				seguro = 2;
			}
		}
		//-------------------------------------------------------------
		if (GameObject.Find ("MainController").GetComponent<MainControlScript> ().Carrera == 0) {
			if (Planeta.name == "Pista1") {
				PlanInst = Instantiate (Planeta, transform.position, Planeta.transform.rotation);
				seguro = 2;
			}
		}
		if (GameObject.Find ("MainController").GetComponent<MainControlScript> ().Carrera == 1) {
			if (Planeta.name == "Pista1" || Planeta.name == "Pista2") {
				PlanInst = Instantiate (Planeta, transform.position, Planeta.transform.rotation);
				seguro = 2;
			}
		}
		if (GameObject.Find ("MainController").GetComponent<MainControlScript> ().Carrera == 2) {
			if (Planeta.name == "Pista1" || Planeta.name == "Pista2" || Planeta.name == "Pista3") {
				PlanInst = Instantiate (Planeta, transform.position, Planeta.transform.rotation);
				seguro = 2;
			}
		}
		if (GameObject.Find ("MainController").GetComponent<MainControlScript> ().Carrera == 3) {
			if (Planeta.name == "Pista1" || Planeta.name == "Pista2" || Planeta.name == "Pista3" || Planeta.name == "Pista4") {
				PlanInst = Instantiate (Planeta, transform.position, Planeta.transform.rotation);
				seguro = 2;
			}
		}
		if (GameObject.Find ("MainController").GetComponent<MainControlScript> ().Carrera == 4) {
			if (Planeta.name == "Pista1" || Planeta.name == "Pista2" || Planeta.name == "Pista3" || Planeta.name == "Pista4" || Planeta.name == "Pista5") {
				PlanInst = Instantiate (Planeta, transform.position, Planeta.transform.rotation);
				seguro = 2;
			}
		}
		//-------------------------------------------------------------
		if (GameObject.Find ("MainController").GetComponent<MainControlScript> ().Defenza == 0) {
			if (Planeta.name == "DefenzaNivel1") {
				PlanInst = Instantiate (Planeta, transform.position, Planeta.transform.rotation);
				seguro = 2;
			}
		}
		if (GameObject.Find ("MainController").GetComponent<MainControlScript> ().Defenza == 1) {
			if (Planeta.name == "DefenzaNivel1" || Planeta.name == "DefenzaNivel2") {
				PlanInst = Instantiate (Planeta, transform.position, Planeta.transform.rotation);
				seguro = 2;
			}
		}
		if (GameObject.Find ("MainController").GetComponent<MainControlScript> ().Defenza == 2) {
			if (Planeta.name == "DefenzaNivel1" || Planeta.name == "DefenzaNivel2" || Planeta.name == "DefenzaNivel3") {
				PlanInst = Instantiate (Planeta, transform.position, Planeta.transform.rotation);
				seguro = 2;
			}
		}
		if (GameObject.Find ("MainController").GetComponent<MainControlScript> ().Defenza == 3) {
			if (Planeta.name == "DefenzaNivel1" || Planeta.name == "DefenzaNivel2" || Planeta.name == "DefenzaNivel3" || Planeta.name == "DefenzaNivel4") {
				PlanInst = Instantiate (Planeta, transform.position, Planeta.transform.rotation);
				seguro = 2;
			}
		}
		if (GameObject.Find ("MainController").GetComponent<MainControlScript> ().Defenza == 4) {
			if (Planeta.name == "DefenzaNivel1" || Planeta.name == "DefenzaNivel2" || Planeta.name == "DefenzaNivel3" || Planeta.name == "DefenzaNivel4" || Planeta.name == "DefenzaNivel5") {
				PlanInst = Instantiate (Planeta, transform.position, Planeta.transform.rotation);
				seguro = 2;
			}
		}
		//-------------------------------------------------------------
		if (GameObject.Find ("MainController").GetComponent<MainControlScript> ().Formas == 0) {
			if (Planeta.name == "FormasNivel1") {
				PlanInst = Instantiate (Planeta, transform.position, Planeta.transform.rotation);
				seguro = 2;
			}
		}
		if (GameObject.Find ("MainController").GetComponent<MainControlScript> ().Formas == 1) {
			if (Planeta.name == "FormasNivel1" || Planeta.name == "FormasNivel2") {
				PlanInst = Instantiate (Planeta, transform.position, Planeta.transform.rotation);
				seguro = 2;
			}
		}
		if (GameObject.Find ("MainController").GetComponent<MainControlScript> ().Formas == 2) {
			if (Planeta.name == "FormasNivel1" || Planeta.name == "FormasNivel2" || Planeta.name == "FormasNivel3") {
				PlanInst = Instantiate (Planeta, transform.position, Planeta.transform.rotation);
				seguro = 2;
			}
		}
		if (GameObject.Find ("MainController").GetComponent<MainControlScript> ().Formas == 3) {
			if (Planeta.name == "FormasNivel1" || Planeta.name == "FormasNivel2" || Planeta.name == "FormasNivel3" || Planeta.name == "FormasNivel4") {
				PlanInst = Instantiate (Planeta, transform.position, Planeta.transform.rotation);
				seguro = 2;
			}
		}
		if (GameObject.Find ("MainController").GetComponent<MainControlScript> ().Formas == 4) {
			if (Planeta.name == "FormasNivel1" || Planeta.name == "FormasNivel2" || Planeta.name == "FormasNivel3" || Planeta.name == "FormasNivel4" || Planeta.name == "FormasNivel5") {
				PlanInst = Instantiate (Planeta, transform.position, Planeta.transform.rotation);
				seguro = 2;
			}
		}
		//-------------------------------------------------------------
		if (GameObject.Find ("MainController").GetComponent<MainControlScript> ().Laberinto == 0) {
			if (Planeta.name == "Laberinto1") {
				PlanInst = Instantiate (Planeta, transform.position, Planeta.transform.rotation);
				seguro = 2;
			}
		}
		if (GameObject.Find ("MainController").GetComponent<MainControlScript> ().Laberinto == 1) {
			if (Planeta.name == "Laberinto1" || Planeta.name == "Laberinto2") {
				PlanInst = Instantiate (Planeta, transform.position, Planeta.transform.rotation);
				seguro = 2;
			}
		}
		if (GameObject.Find ("MainController").GetComponent<MainControlScript> ().Laberinto == 2) {
			if (Planeta.name == "Laberinto1" || Planeta.name == "Laberinto2" || Planeta.name == "Laberinto3") {
				PlanInst = Instantiate (Planeta, transform.position, Planeta.transform.rotation);
				seguro = 2;
			}
		}
		if (GameObject.Find ("MainController").GetComponent<MainControlScript> ().Laberinto == 3) {
			if (Planeta.name == "Laberinto1" || Planeta.name == "Laberinto2" || Planeta.name == "Laberinto3" || Planeta.name == "Laberinto4") {
				PlanInst = Instantiate (Planeta, transform.position, Planeta.transform.rotation);
				seguro = 2;
			}
		}
		if (GameObject.Find ("MainController").GetComponent<MainControlScript> ().Laberinto == 4) {
			if (Planeta.name == "Laberinto1" || Planeta.name == "Laberinto2" || Planeta.name == "Laberinto3" || Planeta.name == "Laberinto4" || Planeta.name == "Laberinto5") {
				PlanInst = Instantiate (Planeta, transform.position, Planeta.transform.rotation);
				seguro = 2;
			}
		}
		//-------------------------------------------------------------
		if (GameObject.Find ("MainController").GetComponent<MainControlScript> ().Shooter == 0) {
			if (Planeta.name == "ShooterNivel1") {
				PlanInst = Instantiate (Planeta, transform.position, Planeta.transform.rotation);
				seguro = 2;
			}
		}
		if (GameObject.Find ("MainController").GetComponent<MainControlScript> ().Shooter == 1) {
			if (Planeta.name == "ShooterNivel1" || Planeta.name == "ShooterNivel2") {
				PlanInst = Instantiate (Planeta, transform.position, Planeta.transform.rotation);
				seguro = 2;
			}
		}
		if (GameObject.Find ("MainController").GetComponent<MainControlScript> ().Shooter == 2) {
			if (Planeta.name == "ShooterNivel1" || Planeta.name == "ShooterNivel2" || Planeta.name == "ShooterNivel3") {
				PlanInst = Instantiate (Planeta, transform.position, Planeta.transform.rotation);
				seguro = 2;
			}
		}
		if (GameObject.Find ("MainController").GetComponent<MainControlScript> ().Shooter == 3) {
			if (Planeta.name == "ShooterNivel1" || Planeta.name == "ShooterNivel2" || Planeta.name == "ShooterNivel3" || Planeta.name == "ShooterNivel4") {
				PlanInst = Instantiate (Planeta, transform.position, Planeta.transform.rotation);
				seguro = 2;
			}
		}
		if (GameObject.Find ("MainController").GetComponent<MainControlScript> ().Shooter == 4) {
			if (Planeta.name == "ShooterNivel1" || Planeta.name == "ShooterNivel2" || Planeta.name == "ShooterNivel3" || Planeta.name == "ShooterNivel4" || Planeta.name == "ShooterNivel5") {
				PlanInst = Instantiate (Planeta, transform.position, Planeta.transform.rotation);
				seguro = 2;
			}
		}
		//-------------------------------------------------------------
		if (GameObject.Find ("MainController").GetComponent<MainControlScript> ().RPG == 0) {
			if (Planeta.name == "RPGPlanet1") {
				PlanInst = Instantiate (Planeta, transform.position, Planeta.transform.rotation);
				seguro = 2;
			}
		}
		if (GameObject.Find ("MainController").GetComponent<MainControlScript> ().RPG == 1) {
			if (Planeta.name == "RPGPlanet1" || Planeta.name == "RPGPlanet2") {
				PlanInst = Instantiate (Planeta, transform.position, Planeta.transform.rotation);
				seguro = 2;
			}
		}
		if (GameObject.Find ("MainController").GetComponent<MainControlScript> ().RPG == 2) {
			if (Planeta.name == "RPGPlanet1" || Planeta.name == "RPGPlanet2" || Planeta.name == "RPGPlanet3") {
				PlanInst = Instantiate (Planeta, transform.position, Planeta.transform.rotation);
				seguro = 2;
			}
		}
		if (GameObject.Find ("MainController").GetComponent<MainControlScript> ().RPG == 3) {
			if (Planeta.name == "RPGPlanet1" || Planeta.name == "RPGPlanet2" || Planeta.name == "RPGPlanet3" || Planeta.name == "RPGPlanet4") {
				PlanInst = Instantiate (Planeta, transform.position, Planeta.transform.rotation);
				seguro = 2;
			}
		}
		if (GameObject.Find ("MainController").GetComponent<MainControlScript> ().RPG == 4) {
			if (Planeta.name == "RPGPlanet1" || Planeta.name == "RPGPlanet2" || Planeta.name == "RPGPlanet3" || Planeta.name == "RPGPlanet4" || Planeta.name == "RPGPlanet5") {
				PlanInst = Instantiate (Planeta, transform.position, Planeta.transform.rotation);
				seguro = 2;
			}
		}
		//PlanInst = Instantiate (Planeta, transform.position, Planeta.transform.rotation);
		//seguro = 2;
	}

	void Update () 
	{
		if (seguro == 2)
		{
			PlanInst.transform.localScale = new Vector3 (tamaño, tamaño, 0);
			PlanInst.transform.position = Vector3.MoveTowards (PlanInst.transform.position, new Vector3 (0, 0, 0), 0.2f);

			if (tamaño < 1)
				tamaño += 0.05f;
			else 
			{
				seguro = 1;
				tamaño = 0.01f;
				SolScript.clicked = 8;
			}
		}
	}
}
