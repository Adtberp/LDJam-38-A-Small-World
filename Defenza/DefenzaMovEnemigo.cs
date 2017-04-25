using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DefenzaMovEnemigo : MonoBehaviour {

	public bool giro;
	private GameObject[] Enemigos;
	public bool paso;

	void Start ()
	{
		giro = false;
	}
	
	void FixedUpdate ()
	{
		if (GameObject.Find ("DefenzaCentroArma") != null)
		{
			if (GameObject.Find ("DefenzaCentroArma").GetComponent<DefenzaDisparo> ().CuentaRegresiva <= 0)
			{
		
				Enemigos = GameObject.FindGameObjectsWithTag ("Enemigo");
				if (gameObject.tag != "Enemigo")
				{
					if (giro)
					{
						transform.Rotate (0, 0, +17 * Time.deltaTime, Space.Self);
					}
					else
					{
						transform.Rotate (0, 0, -17 * Time.deltaTime, Space.Self);
					}
					if (transform.rotation.z >= 0.99)
					{
						giro = false;
						foreach (GameObject Ene in Enemigos)
						{
							Ene.GetComponent<DefenzaMovEnemigo> ().paso = true;
						}
					}
					if (transform.rotation.z <= 0.01)
					{
						giro = true;
						foreach (GameObject Ene in Enemigos)
						{
							Ene.GetComponent<DefenzaMovEnemigo> ().paso = true;
						}
					}
				}else
				{
					if (paso)
					{
						transform.Translate (-0.216f, 0, 0, Space.Self);
						paso = false;
					}
				}
			}
		}
	}
}