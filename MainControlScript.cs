using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MainControlScript : MonoBehaviour {

	public int Snake = 0;
	public int Carrera = 0;
	public int Defenza = 0;
	public int Formas = 0;
	public int Laberinto = 0;
	public int Shooter = 0;
	public int RPG = 0;
	public GameObject SalirNivel;
	public GameObject VolverMenuPrincipal;
	public GameObject NombresPrincipal;
	public GameObject NombresNivel;
	public Text Sol;
	public Text Nivel1;
	public Text Nivel2;
	public Text Nivel3;
	public Text Nivel4;
	public Text Nivel5;
	public GameObject Puntaje;
	public GameObject Objetivo;
	public GameObject Vida;
	public Text Tutorial;
	public Text Tutorial2;

	void Start ()
	{
		
	}
	
	void Update () 
	{
		if (SolScript.clicked == 4 || SolScript.clicked == 6 || SolScript.clicked == 7)
		{
			Vida.SetActive (true);
		}
		if (SolScript.clicked != 4 && SolScript.clicked != 6 && SolScript.clicked != 7 && SolScript.clicked != 8)
		{
			Vida.SetActive (false);
		}
		if (SolScript.clicked == 1 || SolScript.clicked == 2 || SolScript.clicked == 4)
		{
			Puntaje.SetActive (true);
			Objetivo.SetActive (true);
		}
		if (SolScript.clicked != 1 && SolScript.clicked != 2 && SolScript.clicked != 4 && SolScript.clicked != 8)
		{
			Puntaje.SetActive (false);
			Objetivo.SetActive (false);
		}
		if (SolScript.clicked == 0)
		{
			NombresPrincipal.SetActive (true);
		}
		else
		{
			NombresPrincipal.SetActive (false);
		}
		if (SolScript.clicked == 0 || SolScript.clicked == 8)
		{
			NombresNivel.SetActive (false);
			Tutorial.text = " ";
			Tutorial2.text = " ";
		}
		else
		{
			NombresNivel.SetActive (true);
			if (SolScript.clicked == 1)
			{
				Tutorial.text = "Controls: Arrow keys.";
				Tutorial2.text = "Description: The usual.";
				Sol.text = "SNAKE";
				Nivel1.text = "Level 1";
				if (Snake >= 1)
				{
					Nivel2.text = "Level 2";
				}
				else
				{
					Nivel2.text = "Locked";
				}
				if (Snake >= 2)
				{
					Nivel3.text = "Level 3";
				}
				else
				{
					Nivel3.text = "Locked";
				}
				if (Snake >= 3)
				{
					Nivel4.text = "Level 4";
				}
				else
				{
					Nivel4.text = "Locked";
				}
				if (Snake >= 4)
				{
					Nivel5.text = "Level 5";
				}
				else
				{
					Nivel5.text = "Locked";
				}
			}
			if (SolScript.clicked == 2)
			{
				Tutorial.text = "Controls: Arrow keys.";
				Tutorial2.text = "Description: Get to the finish line faster than the time to beat";
				Sol.text = "RACING";
				Nivel1.text = "Level 1";
				if (Carrera >= 1)
				{
					Nivel2.text = "Level 2";
				}
				else
				{
					Nivel2.text = "Locked";
				}
				if (Carrera >= 2)
				{
					Nivel3.text = "Level 3";
				}
				else
				{
					Nivel3.text = "Locked";
				}
				if (Carrera >= 3)
				{
					Nivel4.text = "Level 4";
				}
				else
				{
					Nivel4.text = "Locked";
				}
				if (Carrera >= 4)
				{
					Nivel5.text = "Level 5";
				}
				else
				{
					Nivel5.text = "Locked";
				}
			}
			if (SolScript.clicked == 3)
			{
				Tutorial.text = "Controls: Arrow keys + Space.";
				Tutorial2.text = "Description: Destroy all the enemies before they get to the planet.";
				Sol.text = "INVASION";
				Nivel1.text = "Level 1";
				if (Defenza >= 1)
				{
					Nivel2.text = "Level 2";
				}
				else
				{
					Nivel2.text = "Locked";
				}
				if (Defenza >= 2)
				{
					Nivel3.text = "Level 3";
				}
				else
				{
					Nivel3.text = "Locked";
				}
				if (Defenza >= 3)
				{
					Nivel4.text = "Level 4";
				}
				else
				{
					Nivel4.text = "Locked";
				}
				if (Defenza >= 4)
				{
					Nivel5.text = "Level 5";
				}
				else
				{
					Nivel5.text = "Locked";
				}
			}
			if (SolScript.clicked == 4)
			{
				Tutorial.text = "Controls: Arrow keys.";
				Tutorial2.text = "Description: Match the moving shapes with the ones in the orbit.";
				Sol.text = "SHAPES";
				Nivel1.text = "Level 1";
				if (Formas >= 1)
				{
					Nivel2.text = "Level 2";
				}
				else
				{
					Nivel2.text = "Locked";
				}
				if (Formas >= 2)
				{
					Nivel3.text = "Level 3";
				}
				else
				{
					Nivel3.text = "Locked";
				}
				if (Formas >= 3)
				{
					Nivel4.text = "Level 4";
				}
				else
				{
					Nivel4.text = "Locked";
				}
				if (Formas >= 4)
				{
					Nivel5.text = "Level 5";
				}
				else
				{
					Nivel5.text = "Locked";
				}
			}
			if (SolScript.clicked == 5)
			{
				Tutorial.text = "Controls: Arrow keys.";
				Tutorial2.text = "Description: You know what to do.";
				Sol.text = "MAZE";
				Nivel1.text = "Level 1";
				if (Laberinto >= 1)
				{
					Nivel2.text = "Level 2";
				}
				else
				{
					Nivel2.text = "Locked";
				}
				if (Laberinto >= 2)
				{
					Nivel3.text = "Level 3";
				}
				else
				{
					Nivel3.text = "Locked";
				}
				if (Laberinto >= 3)
				{
					Nivel4.text = "Level 4";
				}
				else
				{
					Nivel4.text = "Locked";
				}
				if (Laberinto >= 4)
				{
					Nivel5.text = "Level 5";
				}
				else
				{
					Nivel5.text = "Locked";
				}
			}
			if (SolScript.clicked == 6)
			{
				Tutorial.text = "Controls: Arrow keys + Mouse.";
				Tutorial2.text = "Description: BRAINS!!";
				Sol.text = "ZOMBIES";
				Nivel1.text = "Level 1";
				if (Shooter >= 1)
				{
					Nivel2.text = "Level 2";
				}
				else
				{
					Nivel2.text = "Locked";
				}
				if (Shooter >= 2)
				{
					Nivel3.text = "Level 3";
				}
				else
				{
					Nivel3.text = "Locked";
				}
				if (Shooter >= 3)
				{
					Nivel4.text = "Level 4";
				}
				else
				{
					Nivel4.text = "Locked";
				}
				if (Shooter >= 4)
				{
					Nivel5.text = "Level 5";
				}
				else
				{
					Nivel5.text = "Locked";
				}
			}
			if (SolScript.clicked == 7)
			{
				Tutorial.text = "Controls: Arrow keys + Space + S.";
				Tutorial2.text = "Description: Exit the dungeon.";
				Sol.text = "KNIGHT";
				Nivel1.text = "Level 1";
				if (RPG >= 1)
				{
					Nivel2.text = "Level 2";
				}
				else
				{
					Nivel2.text = "Locked";
				}
				if (RPG >= 2)
				{
					Nivel3.text = "Level 3";
				}
				else
				{
					Nivel3.text = "Locked";
				}
				if (RPG >= 3)
				{
					Nivel4.text = "Level 4";
				}
				else
				{
					Nivel4.text = "Locked";
				}
				if (RPG >= 4)
				{
					Nivel5.text = "Level 5";
				}
				else
				{
					Nivel5.text = "Locked";
				}
			}
		}
		if (GameObject.FindGameObjectWithTag ("Snake") == null &&
		    GameObject.FindGameObjectWithTag ("Carrera") == null &&
		    GameObject.FindGameObjectWithTag ("Defenza") == null &&
		    GameObject.FindGameObjectWithTag ("Formas") == null &&
		    GameObject.FindGameObjectWithTag ("Laberinto") == null &&
		    GameObject.FindGameObjectWithTag ("Shooter") == null &&
		    GameObject.FindGameObjectWithTag ("RPG") == null)
		{
			SalirNivel.GetComponent<Animator> ().SetBool ("Dentro", false);
		}
		if (GameObject.FindGameObjectWithTag ("Snake")) 
		{
			if (GameObject.Find ("Head").GetComponent<SnakeMainScript> ().NivelCompleto > Snake)
			{
				Snake = GameObject.Find ("Head").GetComponent<SnakeMainScript> ().NivelCompleto;
			}
			if (GameObject.Find ("Head").GetComponent<SnakeMainScript> ().NivelCompleto != 0)
			{
				SalirNivel.GetComponent<Animator> ().SetBool ("Dentro", true);
			}
			if (GameObject.Find ("Head").GetComponent<SnakeMainScript> ().NivelCompleto == 0)
			{
				SalirNivel.GetComponent<Animator> ().SetBool ("Dentro", false);
			}
		}
		if (GameObject.FindGameObjectWithTag ("Carrera")) 
		{
			if (GameObject.Find ("Auto").GetComponent<ControlAuto> ().NivelCompleto > Carrera)
			{
				Carrera = GameObject.Find ("Auto").GetComponent<ControlAuto> ().NivelCompleto;
			}
			if (GameObject.Find ("Auto").GetComponent<ControlAuto> ().NivelCompleto != 0)
			{
				SalirNivel.GetComponent<Animator> ().SetBool ("Dentro", true);
			}
			if (GameObject.Find ("Auto").GetComponent<ControlAuto> ().NivelCompleto == 0)
			{
				SalirNivel.GetComponent<Animator> ().SetBool ("Dentro", false);
			}
		}

		if (GameObject.FindGameObjectWithTag ("Defenza")) 
		{
			if (GameObject.Find ("planeta").GetComponent<DefenzaGiro> ().NivelCompleto > Defenza)
			{
				Defenza = GameObject.Find ("planeta").GetComponent<DefenzaGiro> ().NivelCompleto;
			}
			if (GameObject.Find ("planeta").GetComponent<DefenzaGiro> ().NivelCompleto != 0)
			{
				SalirNivel.GetComponent<Animator> ().SetBool ("Dentro", true);
			}
			if (GameObject.Find ("planeta").GetComponent<DefenzaGiro> ().NivelCompleto == 0)
			{
				SalirNivel.GetComponent<Animator> ().SetBool ("Dentro", false);
			}
		}

		if (GameObject.FindGameObjectWithTag ("Formas")) 
		{
			if (GameObject.Find ("BordeFormas3") != null)
			{
				if (GameObject.Find ("BordeFormas3").GetComponent<GiroFormasContorno> ().NivelCompleto > Formas)
				{
					Formas = GameObject.Find ("BordeFormas3").GetComponent<GiroFormasContorno> ().NivelCompleto;
				}
				if (GameObject.Find ("BordeFormas3").GetComponent<GiroFormasContorno> ().NivelCompleto != 0)
				{
					SalirNivel.GetComponent<Animator> ().SetBool ("Dentro", true);
				}
				if (GameObject.Find ("BordeFormas3").GetComponent<GiroFormasContorno> ().NivelCompleto == 0)
				{
					SalirNivel.GetComponent<Animator> ().SetBool ("Dentro", false);
				}
			}
			if (GameObject.Find ("BordeFormas4") != null)
			{
				if (GameObject.Find ("BordeFormas4").GetComponent<GiroFormasContorno> ().NivelCompleto > Formas)
				{
					Formas = GameObject.Find ("BordeFormas4").GetComponent<GiroFormasContorno> ().NivelCompleto;
				}
				if (GameObject.Find ("BordeFormas4").GetComponent<GiroFormasContorno> ().NivelCompleto != 0)
				{
					SalirNivel.GetComponent<Animator> ().SetBool ("Dentro", true);
				}
				if (GameObject.Find ("BordeFormas4").GetComponent<GiroFormasContorno> ().NivelCompleto == 0)
				{
					SalirNivel.GetComponent<Animator> ().SetBool ("Dentro", false);
				}
			}
			if (GameObject.Find ("BordeFormas5") != null)
			{
				if (GameObject.Find ("BordeFormas5").GetComponent<GiroFormasContorno> ().NivelCompleto > Formas)
				{
					Formas = GameObject.Find ("BordeFormas5").GetComponent<GiroFormasContorno> ().NivelCompleto;
				}
				if (GameObject.Find ("BordeFormas5").GetComponent<GiroFormasContorno> ().NivelCompleto != 0)
				{
					SalirNivel.GetComponent<Animator> ().SetBool ("Dentro", true);
				}
				if (GameObject.Find ("BordeFormas5").GetComponent<GiroFormasContorno> ().NivelCompleto == 0)
				{
					SalirNivel.GetComponent<Animator> ().SetBool ("Dentro", false);
				}
			}
		}

		if (GameObject.FindGameObjectWithTag ("Laberinto")) 
		{
			if (GameObject.Find ("LaberintoJugador").GetComponent<LaberintoJugador> ().NivelCompleto > Laberinto)
			{
				Laberinto = GameObject.Find ("LaberintoJugador").GetComponent<LaberintoJugador> ().NivelCompleto;
			}
			if (GameObject.Find ("LaberintoJugador").GetComponent<LaberintoJugador> ().NivelCompleto != 0)
			{
				SalirNivel.GetComponent<Animator> ().SetBool ("Dentro", true);
			}
			if (GameObject.Find ("LaberintoJugador").GetComponent<LaberintoJugador> ().NivelCompleto == 0)
			{
				SalirNivel.GetComponent<Animator> ().SetBool ("Dentro", false);
			}
		}

		if (GameObject.FindGameObjectWithTag ("Shooter")) 
		{
			if (GameObject.Find ("planeta").GetComponent<ShooterNivelCompleto> ().NivelCompleto > Shooter)
			{
				Shooter = GameObject.Find ("planeta").GetComponent<ShooterNivelCompleto> ().NivelCompleto;
			}
			if (GameObject.Find ("planeta").GetComponent<ShooterNivelCompleto> ().NivelCompleto != 0)
			{
				SalirNivel.GetComponent<Animator> ().SetBool ("Dentro", true);
			}
			if (GameObject.Find ("planeta").GetComponent<ShooterNivelCompleto> ().NivelCompleto == 0)
			{
				SalirNivel.GetComponent<Animator> ().SetBool ("Dentro", false);
			}
		}

		if (GameObject.FindGameObjectWithTag ("RPG")) 
		{
			if (GameObject.Find ("RPGPuerta").GetComponent<RPGNivelCompleto> ().NivelCompleto > RPG)
			{
				RPG = GameObject.Find ("RPGPuerta").GetComponent<RPGNivelCompleto> ().NivelCompleto;
			}
			if (GameObject.Find ("RPGPuerta").GetComponent<RPGNivelCompleto> ().NivelCompleto != 0)
			{
				SalirNivel.GetComponent<Animator> ().SetBool ("Dentro", true);
			}
			if (GameObject.Find ("RPGPuerta").GetComponent<RPGNivelCompleto> ().NivelCompleto == 0)
			{
				SalirNivel.GetComponent<Animator> ().SetBool ("Dentro", false);
			}
		}
	}
	public void SaliEndoNivel ()
	{
		if (GameObject.FindGameObjectWithTag ("Snake") != null)
		{
			SolScript.clicked = 1;
			Destroy (GameObject.FindGameObjectWithTag ("Snake"));
		}
		if (GameObject.FindGameObjectWithTag ("Carrera") != null)
		{
			SolScript.clicked = 2;
			Destroy (GameObject.FindGameObjectWithTag ("Carrera"));
		}
		if (GameObject.FindGameObjectWithTag ("Defenza") != null)
		{
			SolScript.clicked = 3;
			Destroy (GameObject.FindGameObjectWithTag ("Defenza"));
		}
		if (GameObject.FindGameObjectWithTag ("Formas") != null)
		{
			SolScript.clicked = 4;
			Destroy (GameObject.FindGameObjectWithTag ("Formas"));
		}
		if (GameObject.FindGameObjectWithTag ("Laberinto") != null)
		{
			SolScript.clicked = 5;
			Destroy (GameObject.FindGameObjectWithTag ("Laberinto"));
		}
		if (GameObject.FindGameObjectWithTag ("Shooter") != null)
		{
			SolScript.clicked = 6;
			Destroy (GameObject.FindGameObjectWithTag ("Shooter"));
		}
		if (GameObject.FindGameObjectWithTag ("RPG") != null)
		{
			SolScript.clicked = 7;
			Destroy (GameObject.FindGameObjectWithTag ("RPG"));
		}
	}
}
