using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaberintoJugador : MonoBehaviour {

	private float PuntoMovimientoY;
	private float PuntoMovimientoX;
	public int NivelCompleto;

	void Start ()
	{
	}
	
	void Update ()
	{
		if (NivelCompleto == 0)
		{
			if (Input.GetKey ("up") && Input.GetKey ("down"))
			{
				PuntoMovimientoY = transform.position.y;
				gameObject.GetComponent<Animator> ().SetBool ("Caminando", false);
			}
			else if (Input.GetKey ("up"))
			{
				PuntoMovimientoY = Mathf.MoveTowards (transform.position.y, transform.position.y + 1, 0.8f * Time.deltaTime);
				transform.rotation = Quaternion.Euler (new Vector3 (0, 0, 0));
				gameObject.GetComponent<Animator> ().SetBool ("Caminando", true);
			}
			else if (Input.GetKey ("down"))
			{
				PuntoMovimientoY = Mathf.MoveTowards (transform.position.y, transform.position.y - 1, 0.8f * Time.deltaTime);
				transform.rotation = Quaternion.Euler (new Vector3 (0, 0, 180));
				gameObject.GetComponent<Animator> ().SetBool ("Caminando", true);
			}
			if (Input.GetKey ("left") && Input.GetKey ("right"))
			{
				PuntoMovimientoX = transform.position.x;
				gameObject.GetComponent<Animator> ().SetBool ("Caminando", false);
			}
			else if (Input.GetKey ("left"))
			{
				PuntoMovimientoX = Mathf.MoveTowards (transform.position.x, transform.position.x - 1, 0.8f * Time.deltaTime);
				transform.rotation = Quaternion.Euler (new Vector3 (0, 0, 90));
				gameObject.GetComponent<Animator> ().SetBool ("Caminando", true);
			}
			else if (Input.GetKey ("right"))
			{
				PuntoMovimientoX = Mathf.MoveTowards (transform.position.x, transform.position.x + 1, 0.8f * Time.deltaTime);
				transform.rotation = Quaternion.Euler (new Vector3 (0, 0, -90));
				gameObject.GetComponent<Animator> ().SetBool ("Caminando", true);
			}
			if (Input.GetKeyUp ("up") || Input.GetKeyUp ("down") || Input.GetKeyUp ("right") || Input.GetKeyUp ("left")) {
				PuntoMovimientoY = transform.position.y;
				PuntoMovimientoX = transform.position.x;
				gameObject.GetComponent<Animator> ().SetBool ("Caminando", false);
			}
			transform.position = new Vector2 (PuntoMovimientoX, PuntoMovimientoY);
		}
	}
	void OnTriggerEnter2D (Collider2D otro)
	{
		if (otro.gameObject.name == "Salida")
		{
			if (GameObject.Find ("Laberinto1(Clone)") != null)
			{
				NivelCompleto = 1;
			}
			if (GameObject.Find ("Laberinto2(Clone)") != null)
			{
				NivelCompleto = 2;
			}
			if (GameObject.Find ("Laberinto3(Clone)") != null)
			{
				NivelCompleto = 3;
			}
			if (GameObject.Find ("Laberinto4(Clone)") != null)
			{
				NivelCompleto = 4;
			}
			if (GameObject.Find ("Laberinto5(Clone)") != null)
			{
				NivelCompleto = 5;
			}
		}
	}
}
