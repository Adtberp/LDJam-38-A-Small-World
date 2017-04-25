using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientoFormas : MonoBehaviour {

	public int ElegirDireccion;

	void Start ()
	{
		if (GameObject.Find ("BordeFormas5"))
		{
			ElegirDireccion = UnityEngine.Random.Range (0, 5);
			if (ElegirDireccion == 0)
			{
				transform.rotation = Quaternion.Euler (0, 0, 72);
			}
			if (ElegirDireccion == 1)
			{
				transform.rotation = Quaternion.Euler (0, 0, 144);
			}
			if (ElegirDireccion == 2)
			{
				transform.rotation = Quaternion.Euler (0, 0, -144);
			}
			if (ElegirDireccion == 3)
			{
				transform.rotation = Quaternion.Euler (0, 0, -72);
			}
			if (ElegirDireccion == 4)
			{
				transform.rotation = Quaternion.Euler (0, 0, 0);
			}
		}
		if (GameObject.Find ("BordeFormas4"))
		{
			ElegirDireccion = UnityEngine.Random.Range (0, 4);
			if (ElegirDireccion == 0)
			{
				transform.rotation = Quaternion.Euler (0, 0, 0);
			}
			if (ElegirDireccion == 1)
			{
				transform.rotation = Quaternion.Euler (0, 0, 90);
			}
			if (ElegirDireccion == 2)
			{
				transform.rotation = Quaternion.Euler (0, 0, 180);
			}
			if (ElegirDireccion == 3)
			{
				transform.rotation = Quaternion.Euler (0, 0, 270);
			}
		}
		if (GameObject.Find ("BordeFormas3"))
		{
			ElegirDireccion = UnityEngine.Random.Range (0, 3);
			if (ElegirDireccion == 0)
			{
				transform.rotation = Quaternion.Euler (0, 0, 0);
			}
			if (ElegirDireccion == 1)
			{
				transform.rotation = Quaternion.Euler (0, 0, 120);
			}
			if (ElegirDireccion == 2)
			{
				transform.rotation = Quaternion.Euler (0, 0, 240);
			}
		}
	}

	void Update ()
	{
		if(GameObject.Find("BordeFormas5"))
		{
			transform.Translate (new Vector2 (1.8f * Time.deltaTime, 0));
		}
		if(GameObject.Find("BordeFormas4") || GameObject.Find("BordeFormas3"))
		{
			transform.Translate (new Vector2 (0, 1.8f * Time.deltaTime));
		}
	}
	void OnTriggerEnter2D (Collider2D otro)
	{
		if (gameObject.name == "Circulo(Clone)")
		{
			if (otro.name == "FormasCirculo")
			{
				Destroy (gameObject, 1f);
				GameObject.FindWithTag ("BordeForma").GetComponent<GiroFormasContorno> ().Puntos += 1;
			}
			else
			{
				Destroy (gameObject);
				GameObject.FindWithTag ("BordeForma").GetComponent<GiroFormasContorno> ().Vida -= 1;
			}
		}
		if (gameObject.name == "Cuadrado(Clone)")
		{
			if (otro.name == "FormasCuadrado")
			{
				Destroy (gameObject, 1f);
				GameObject.FindWithTag ("BordeForma").GetComponent<GiroFormasContorno> ().Puntos += 1;
			}
			else
			{
				Destroy (gameObject);
				GameObject.FindWithTag ("BordeForma").GetComponent<GiroFormasContorno> ().Vida -= 1;
			}
		}
		if (gameObject.name == "Estrella(Clone)")
		{
			if (otro.name == "FormasEstrella")
			{
				Destroy (gameObject, 1f);
				GameObject.FindWithTag ("BordeForma").GetComponent<GiroFormasContorno> ().Puntos += 1;
			}
			else
			{
				Destroy (gameObject);
				GameObject.FindWithTag ("BordeForma").GetComponent<GiroFormasContorno> ().Vida -= 1;
			}
		}
		if (gameObject.name == "Triangulo(Clone)")
		{
			if (otro.name == "FormasTriangulo")
			{
				Destroy (gameObject, 1f);
				GameObject.FindWithTag ("BordeForma").GetComponent<GiroFormasContorno> ().Puntos += 1;
			}
			else
			{
				Destroy (gameObject);
				GameObject.FindWithTag ("BordeForma").GetComponent<GiroFormasContorno> ().Vida -= 1;
			}
		}
		if (gameObject.name == "Pentagono(Clone)")
		{
			if (otro.name == "FormasPentagono")
			{
				Destroy (gameObject, 1f);
				GameObject.FindWithTag ("BordeForma").GetComponent<GiroFormasContorno> ().Puntos += 1;
			}
			else
			{
				Destroy (gameObject);
				GameObject.FindWithTag ("BordeForma").GetComponent<GiroFormasContorno> ().Vida -= 1;
			}
		}
	}
}
