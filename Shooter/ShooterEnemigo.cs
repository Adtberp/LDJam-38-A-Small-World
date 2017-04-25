using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShooterEnemigo : MonoBehaviour {

	private Vector3 Direccion;
	private float diferencia;
	public int VidaEnemigo;
	private float Margen;
	private float Velocidad;

	void Start ()
	{
		Margen = UnityEngine.Random.Range (150, 240);
		if (GameObject.Find ("ShooterNivel1(Clone)"))
		{
			VidaEnemigo = UnityEngine.Random.Range (1, 3);
		}
		if (GameObject.Find ("ShooterNivel2(Clone)"))
		{
			VidaEnemigo = UnityEngine.Random.Range (2, 4);
		}
		if (GameObject.Find ("ShooterNivel3(Clone)"))
		{
			VidaEnemigo = UnityEngine.Random.Range (3, 5);
		}
		if (GameObject.Find ("ShooterNivel4(Clone)"))
		{
			VidaEnemigo = UnityEngine.Random.Range (4, 6);
		}
		if (GameObject.Find ("ShooterNivel5(Clone)"))
		{
			VidaEnemigo = UnityEngine.Random.Range (5, 7);
		}
		Velocidad = UnityEngine.Random.Range (0.009f, 0.0151f);
	}
	void Update ()
	{
		if (GameObject.Find ("ShooterPersonaje") != null)
		{
			if (GameObject.Find ("ShooterPersonaje").GetComponent<ShooterPersonaje> ().CuentaRegresiva <= 0)
			{
				if (VidaEnemigo == 0)
				{
					Destroy (gameObject);
				}
				Direccion = GameObject.Find ("ShooterPersonaje").transform.position - transform.position;
				diferencia = Mathf.Atan2 (Direccion.y, Direccion.x) * Mathf.Rad2Deg;
				transform.rotation = Quaternion.RotateTowards (transform.rotation, Quaternion.Euler (0, 0, diferencia), Margen * Time.deltaTime);
				float tempx = Mathf.MoveTowards (transform.position.x, GameObject.Find ("ShooterPersonaje").transform.position.x, Velocidad);
				float tempy = Mathf.MoveTowards (transform.position.y, GameObject.Find ("ShooterPersonaje").transform.position.y, Velocidad);
				transform.position = new Vector3 (tempx, tempy, transform.position.z);
			}
		}
	}
	void OnTriggerEnter2D (Collider2D otro)
	{
		if (otro.gameObject.name == "ShooterDisparo(Clone)") 
		{
			VidaEnemigo -= 1;
			Destroy (otro.gameObject);
		}
	}
}