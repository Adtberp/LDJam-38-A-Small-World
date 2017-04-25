using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SolScript : MonoBehaviour {

	static public int clicked = 0;
	private float rot = 0;
	private int incremento = 1;
	private Vector3 posicioninicio;
	private CircleCollider2D asd;
	public Sprite[] barraProgreso;
	public GameObject barraobjeto;
	public Image imagen;




	void Start () 
	{
		posicioninicio = transform.position;
		incremento = Random.Range (5, 10);
		//sprbarra = barraobjeto.GetComponent<SpriteRenderer> ();
		//asd = GetComponent<CircleCollider2D> ();
	}
	
	void OnMouseUp()
	{
		if (gameObject.name == "Sol1")
			clicked = 1;
		
		if (gameObject.name == "Sol2")
			clicked = 2;

		if (gameObject.name == "Sol3")
			clicked = 3;

		if (gameObject.name == "Sol4")
			clicked = 4;

		if (gameObject.name == "Sol5")
			clicked = 5;

		if (gameObject.name == "Sol6")
			clicked = 6;
		
		if (gameObject.name == "Sol7")
			clicked = 7;

	}

	public void volver()
	{
		if (clicked != 0 && clicked != 8)
		{
			clicked = 0;
		}
	}

	void Update () 
	{
		if (clicked != 0 && clicked != 8)
		{
			GameObject.Find ("VolverMenuPrincipal").GetComponent<Animator> ().SetBool ("Dentro", true);
			barraobjeto.SetActive (true);

		}
		else
		{
			GameObject.Find ("VolverMenuPrincipal").GetComponent<Animator> ().SetBool ("Dentro", false);
			barraobjeto.SetActive (false);
		}

		if (clicked == 0) 
		{
			transform.position = Vector3.MoveTowards (transform.position, posicioninicio, 0.1f);
			transform.rotation = Quaternion.Euler (new Vector3 (0, 0, rot));
			rot += incremento * Time.deltaTime;
		} 
		else 
		{
			transform.rotation = Quaternion.Euler (new Vector3 (0, 0, 0));

		}

		if (clicked == 1) 
		{
			imagen.sprite = barraProgreso [GameObject.Find ("MainController").GetComponent<MainControlScript> ().Snake];
			if (gameObject.name == "Sol1")
				transform.position = Vector3.MoveTowards (transform.position, new Vector3 (0,2,0), 0.1f);

			if (gameObject.name == "Sol2")
				transform.position = Vector3.MoveTowards (transform.position, new Vector3 (-8.2f, 7.76f,0), 0.1f);

			if (gameObject.name == "Sol3")
				transform.position = Vector3.MoveTowards (transform.position, new Vector3 (0f, 10f,0), 0.1f);

			if (gameObject.name == "Sol4")
				transform.position = Vector3.MoveTowards (transform.position, new Vector3 (7.15f, 7.34f,0), 0.1f);

			if (gameObject.name == "Sol5")
				transform.position = Vector3.MoveTowards (transform.position, new Vector3 (9.5f, -1f,0), 0.1f);

			if (gameObject.name == "Sol6")
				transform.position = Vector3.MoveTowards (transform.position, new Vector3 (4.25f, -8.1f,0), 0.1f);

			if (gameObject.name == "Sol7")
				transform.position = Vector3.MoveTowards (transform.position, new Vector3 (-6.6f, -8.1f,0), 0.1f);
		}
		if (clicked == 2) 
		{
			imagen.sprite = barraProgreso [GameObject.Find ("MainController").GetComponent<MainControlScript> ().Carrera];
			if (gameObject.name == "Sol1")
				transform.position = Vector3.MoveTowards (transform.position, new Vector3 (-11,-1,0), 0.1f);

			if (gameObject.name == "Sol2")
				transform.position = Vector3.MoveTowards (transform.position, new Vector3 (0, 2,0), 0.1f);

			if (gameObject.name == "Sol3")
				transform.position = Vector3.MoveTowards (transform.position, new Vector3 (0f, 10f,0), 0.1f);

			if (gameObject.name == "Sol4")
				transform.position = Vector3.MoveTowards (transform.position, new Vector3 (7.15f, 7.34f,0), 0.1f);

			if (gameObject.name == "Sol5")
				transform.position = Vector3.MoveTowards (transform.position, new Vector3 (9.5f, -1f,0), 0.1f);

			if (gameObject.name == "Sol6")
				transform.position = Vector3.MoveTowards (transform.position, new Vector3 (4.25f, -8.1f,0), 0.1f);

			if (gameObject.name == "Sol7")
				transform.position = Vector3.MoveTowards (transform.position, new Vector3 (-6.6f, -8.1f,0), 0.1f);
		}

		if (clicked == 3) 
		{
			imagen.sprite = barraProgreso [GameObject.Find ("MainController").GetComponent<MainControlScript> ().Defenza];
			if (gameObject.name == "Sol1")
				transform.position = Vector3.MoveTowards (transform.position, new Vector3 (-11,-1,0), 0.1f);

			if (gameObject.name == "Sol2")
				transform.position = Vector3.MoveTowards (transform.position, new Vector3 (-8.2f, 7.76f,0), 0.1f);

			if (gameObject.name == "Sol3")
				transform.position = Vector3.MoveTowards (transform.position, new Vector3 (0f, 2,0), 0.1f);

			if (gameObject.name == "Sol4")
				transform.position = Vector3.MoveTowards (transform.position, new Vector3 (7.15f, 7.34f,0), 0.1f);

			if (gameObject.name == "Sol5")
				transform.position = Vector3.MoveTowards (transform.position, new Vector3 (9.5f, -1f,0), 0.1f);

			if (gameObject.name == "Sol6")
				transform.position = Vector3.MoveTowards (transform.position, new Vector3 (4.25f, -8.1f,0), 0.1f);

			if (gameObject.name == "Sol7")
				transform.position = Vector3.MoveTowards (transform.position, new Vector3 (-6.6f, -8.1f,0), 0.1f);
		}
		if (clicked == 4) 
		{
			imagen.sprite = barraProgreso [GameObject.Find ("MainController").GetComponent<MainControlScript> ().Formas];
			if (gameObject.name == "Sol1")
				transform.position = Vector3.MoveTowards (transform.position, new Vector3 (-11,-1,0), 0.1f);

			if (gameObject.name == "Sol2")
				transform.position = Vector3.MoveTowards (transform.position, new Vector3 (-8.2f, 7.76f,0), 0.1f);

			if (gameObject.name == "Sol3")
				transform.position = Vector3.MoveTowards (transform.position, new Vector3 (0f, 10f,0), 0.1f);

			if (gameObject.name == "Sol4")
				transform.position = Vector3.MoveTowards (transform.position, new Vector3 (0, 2,0), 0.1f);

			if (gameObject.name == "Sol5")
				transform.position = Vector3.MoveTowards (transform.position, new Vector3 (9.5f, -1f,0), 0.1f);

			if (gameObject.name == "Sol6")
				transform.position = Vector3.MoveTowards (transform.position, new Vector3 (4.25f, -8.1f,0), 0.1f);

			if (gameObject.name == "Sol7")
				transform.position = Vector3.MoveTowards (transform.position, new Vector3 (-6.6f, -8.1f,0), 0.1f);
		}
		if (clicked == 5) 
		{
			imagen.sprite = barraProgreso [GameObject.Find ("MainController").GetComponent<MainControlScript> ().Laberinto];
			if (gameObject.name == "Sol1")
				transform.position = Vector3.MoveTowards (transform.position, new Vector3 (-11,-1,0), 0.1f);

			if (gameObject.name == "Sol2")
				transform.position = Vector3.MoveTowards (transform.position, new Vector3 (-8.2f, 7.76f,0), 0.1f);

			if (gameObject.name == "Sol3")
				transform.position = Vector3.MoveTowards (transform.position, new Vector3 (0f, 10f,0), 0.1f);

			if (gameObject.name == "Sol4")
				transform.position = Vector3.MoveTowards (transform.position, new Vector3 (7.15f, 7.34f,0), 0.1f);

			if (gameObject.name == "Sol5")
				transform.position = Vector3.MoveTowards (transform.position, new Vector3 (0, 2,0), 0.1f);

			if (gameObject.name == "Sol6")
				transform.position = Vector3.MoveTowards (transform.position, new Vector3 (4.25f, -8.1f,0), 0.1f);

			if (gameObject.name == "Sol7")
				transform.position = Vector3.MoveTowards (transform.position, new Vector3 (-6.6f, -8.1f,0), 0.1f);
		}
		if (clicked == 6) 
		{
			imagen.sprite = barraProgreso [GameObject.Find ("MainController").GetComponent<MainControlScript> ().Shooter];
			if (gameObject.name == "Sol1")
				transform.position = Vector3.MoveTowards (transform.position, new Vector3 (-11,-1,0), 0.1f);

			if (gameObject.name == "Sol2")
				transform.position = Vector3.MoveTowards (transform.position, new Vector3 (-8.2f, 7.76f,0), 0.1f);

			if (gameObject.name == "Sol3")
				transform.position = Vector3.MoveTowards (transform.position, new Vector3 (0f, 10f,0), 0.1f);

			if (gameObject.name == "Sol4")
				transform.position = Vector3.MoveTowards (transform.position, new Vector3 (7.15f, 7.34f,0), 0.1f);

			if (gameObject.name == "Sol5")
				transform.position = Vector3.MoveTowards (transform.position, new Vector3 (9.5f, -1f,0), 0.1f);

			if (gameObject.name == "Sol6")
				transform.position = Vector3.MoveTowards (transform.position, new Vector3 (0, 2,0), 0.1f);

			if (gameObject.name == "Sol7")
				transform.position = Vector3.MoveTowards (transform.position, new Vector3 (-6.6f, -8.1f,0), 0.1f);
		}
		if (clicked == 7) 
		{
			imagen.sprite = barraProgreso [GameObject.Find ("MainController").GetComponent<MainControlScript> ().RPG];
			if (gameObject.name == "Sol1")
				transform.position = Vector3.MoveTowards (transform.position, new Vector3 (-11,-1,0), 0.1f);

			if (gameObject.name == "Sol2")
				transform.position = Vector3.MoveTowards (transform.position, new Vector3 (-8.2f, 7.76f,0), 0.1f);

			if (gameObject.name == "Sol3")
				transform.position = Vector3.MoveTowards (transform.position, new Vector3 (0f, 10f,0), 0.1f);

			if (gameObject.name == "Sol4")
				transform.position = Vector3.MoveTowards (transform.position, new Vector3 (7.15f, 7.34f,0), 0.1f);

			if (gameObject.name == "Sol5")
				transform.position = Vector3.MoveTowards (transform.position, new Vector3 (9.5f, -1f,0), 0.1f);

			if (gameObject.name == "Sol6")
				transform.position = Vector3.MoveTowards (transform.position, new Vector3 (4.25f, -8.1f,0), 0.1f);

			if (gameObject.name == "Sol7")
				transform.position = Vector3.MoveTowards (transform.position, new Vector3 (0, 2,0), 0.1f);
		}

		if (clicked == 8) 
		{
			GetComponent<CircleCollider2D> ().enabled = false;

			if (gameObject.name == "Sol1")
				transform.position = Vector3.MoveTowards (transform.position, new Vector3 (-11, -1, 0), 1f);

			if (gameObject.name == "Sol2")
				transform.position = Vector3.MoveTowards (transform.position, new Vector3 (-8.2f, 7.76f, 0), 1f);

			if (gameObject.name == "Sol3")
				transform.position = Vector3.MoveTowards (transform.position, new Vector3 (0f, 10f, 0), 1f);

			if (gameObject.name == "Sol4")
				transform.position = Vector3.MoveTowards (transform.position, new Vector3 (7.15f, 7.34f, 0), 1f);

			if (gameObject.name == "Sol5")
				transform.position = Vector3.MoveTowards (transform.position, new Vector3 (9.5f, -1f, 0), 1f);

			if (gameObject.name == "Sol6")
				transform.position = Vector3.MoveTowards (transform.position, new Vector3 (4.25f, -8.1f, 0), 1f);

			if (gameObject.name == "Sol7")
				transform.position = Vector3.MoveTowards (transform.position, new Vector3 (-6.6f, -8.1f, 0), 1f);
		}
		else 
		{
			GetComponent<CircleCollider2D> ().enabled = true;
		}

		if (clicked == 1 & gameObject.name == "Sol1" & transform.position == new Vector3 (0, 2, 0)) 
		{
			transform.GetChild (0).gameObject.SetActive (true);
			transform.GetChild (1).gameObject.SetActive (true);
			transform.GetChild (2).gameObject.SetActive (true);
			transform.GetChild (3).gameObject.SetActive (true);
			transform.GetChild (4).gameObject.SetActive (true);
		} 
		if (clicked == 2 & gameObject.name == "Sol2" & transform.position == new Vector3 (0, 2, 0)) 
		{
			transform.GetChild (0).gameObject.SetActive (true);
			transform.GetChild (1).gameObject.SetActive (true);
			transform.GetChild (2).gameObject.SetActive (true);
			transform.GetChild (3).gameObject.SetActive (true);
			transform.GetChild (4).gameObject.SetActive (true);
		} 
		if (clicked == 3 & gameObject.name == "Sol3" & transform.position == new Vector3 (0, 2, 0)) 
		{
			transform.GetChild (0).gameObject.SetActive (true);
			transform.GetChild (1).gameObject.SetActive (true);
			transform.GetChild (2).gameObject.SetActive (true);
			transform.GetChild (3).gameObject.SetActive (true);
			transform.GetChild (4).gameObject.SetActive (true);
		} 
		if (clicked == 4 & gameObject.name == "Sol4" & transform.position == new Vector3 (0, 2, 0)) 
		{
			transform.GetChild (0).gameObject.SetActive (true);
			transform.GetChild (1).gameObject.SetActive (true);
			transform.GetChild (2).gameObject.SetActive (true);
			transform.GetChild (3).gameObject.SetActive (true);
			transform.GetChild (4).gameObject.SetActive (true);
		} 
		if (clicked == 5 & gameObject.name == "Sol5" & transform.position == new Vector3 (0, 2, 0)) 
		{
			transform.GetChild (0).gameObject.SetActive (true);
			transform.GetChild (1).gameObject.SetActive (true);
			transform.GetChild (2).gameObject.SetActive (true);
			transform.GetChild (3).gameObject.SetActive (true);
			transform.GetChild (4).gameObject.SetActive (true);
		} 
		if (clicked == 6 & gameObject.name == "Sol6" & transform.position == new Vector3 (0, 2, 0)) 
		{
			transform.GetChild (0).gameObject.SetActive (true);
			transform.GetChild (1).gameObject.SetActive (true);
			transform.GetChild (2).gameObject.SetActive (true);
			transform.GetChild (3).gameObject.SetActive (true);
			transform.GetChild (4).gameObject.SetActive (true);
		} 
		if (clicked == 7 & gameObject.name == "Sol7" & transform.position == new Vector3 (0, 2, 0)) 
		{
			transform.GetChild (0).gameObject.SetActive (true);
			transform.GetChild (1).gameObject.SetActive (true);
			transform.GetChild (2).gameObject.SetActive (true);
			transform.GetChild (3).gameObject.SetActive (true);
			transform.GetChild (4).gameObject.SetActive (true);
		} 
		if (transform.position.x != 0 || transform.position.y != 2)
		{
			transform.GetChild (0).gameObject.SetActive (false);
			transform.GetChild (1).gameObject.SetActive (false);
			transform.GetChild (2).gameObject.SetActive (false);
			transform.GetChild (3).gameObject.SetActive (false);
			transform.GetChild (4).gameObject.SetActive (false);
		}
	}
}
