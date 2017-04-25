using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShooterNivelCompleto : MonoBehaviour {

	public int NivelCompleto;

	void Start ()
	{
	}
	void Update ()
	{
		if (GameObject.FindWithTag ("Enemigo") == null)
		{
			if (GameObject.Find ("ShooterNivel1(Clone)") != null)
			{
				NivelCompleto = 1;
			}
			if (GameObject.Find ("ShooterNivel2(Clone)") != null)
			{
				NivelCompleto = 2;
			}
			if (GameObject.Find ("ShooterNivel3(Clone)") != null)
			{
				NivelCompleto = 3;
			}
			if (GameObject.Find ("ShooterNivel4(Clone)") != null)
			{
				NivelCompleto = 4;
			}
			if (GameObject.Find ("ShooterNivel5(Clone)") != null)
			{
				NivelCompleto = 5;
			}
		}
		if (GameObject.Find ("ShooterPersonaje") == null)
		{
			NivelCompleto = -1;
		}
	}
}
