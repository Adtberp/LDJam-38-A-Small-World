using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SnakeMainScript : MonoBehaviour {

	public int direccion = 1; // 1 arriba 2 derecha 3 abajo 4 izquierda
	private int movcont = 0;
	public GameObject cuerpo;
	static public int snakebodylenght = 5;
	public GameObject huevo;
	private float CuentaRegresiva;
	private Text CRegrsivaUI;
	public int NivelCompleto;
	private int Puntos;
	private Text PuntosUI;
	private int Objetivo;
	private Text ObjetivoUI;
	private Text TextoObjetivo;
	private Text TextoPuntos;
	private bool Muerto;

	void Start () 
	{
		Muerto = false;
		TextoObjetivo = GameObject.Find ("PuntajeObjetivo").GetComponent<Text> ();
		TextoPuntos = GameObject.Find ("Puntaje").GetComponent<Text> ();
		PuntosUI = GameObject.Find ("PuntajeMiniJuego").GetComponent<Text> ();
		ObjetivoUI = GameObject.Find ("PuntajeNivel").GetComponent<Text> ();
		CRegrsivaUI = GameObject.Find ("CuentaRegresiva").GetComponent<Text> ();
		CuentaRegresiva = 3;
	}

	void OnTriggerEnter2D (Collider2D other)
	{
		if (other.gameObject.tag == "HuevoSnake") 
		{
			Destroy (other.gameObject);
			snakebodylenght += 1;
			Instantiate (huevo, new Vector3 (0,0,0), huevo.transform.rotation);
		}
		else 
		{
			NivelCompleto = -1;
			Muerto = true;
		}
			
	}

	void Update () 
	{
		TextoPuntos.text = "  Score :";
		TextoObjetivo.text = "  Score To Beat :";
		Puntos = snakebodylenght - 5;
		PuntosUI.text = Puntos.ToString ();
		ObjetivoUI.text = Objetivo.ToString ();
		if (CuentaRegresiva > 0)
		{
			CRegrsivaUI.text = CuentaRegresiva.ToString ("F1");
			CuentaRegresiva -= Time.deltaTime;
		}
		if (CuentaRegresiva <= 0 && Muerto == false && NivelCompleto == 0)
		{
			CRegrsivaUI.text = " ";

			movcont += 1;
			if (movcont == 10)
			{
				Instantiate (cuerpo, transform.position, transform.rotation);


				if (direccion == 1)
				{
					transform.rotation = Quaternion.Euler (new Vector3 (0, 0, 0));
					transform.position = new Vector3 (transform.position.x, (transform.position.y + 0.16f), transform.position.z);
				}
				if (direccion == 2)
				{
					transform.rotation = Quaternion.Euler (new Vector3 (0, 0, -90));
					transform.position = new Vector3 (transform.position.x + 0.16f, transform.position.y, transform.position.z);
				}
				if (direccion == 3)
				{
					transform.rotation = Quaternion.Euler (new Vector3 (0, 0, 180));
					transform.position = new Vector3 (transform.position.x, (transform.position.y - 0.16f), transform.position.z);
				}
				if (direccion == 4)
				{
					transform.rotation = Quaternion.Euler (new Vector3 (0, 0, 90));
					transform.position = new Vector3 (transform.position.x - 0.16f, transform.position.y, transform.position.z);
				}
				movcont = 0;
			}
			if (Input.GetKey ("up"))
			{
				if (direccion != 3)
					direccion = 1;
			}
			if (Input.GetKey ("down"))
			{
				if (direccion != 1)
					direccion = 3;
			}
			if (Input.GetKey ("left"))
			{
				if (direccion != 2)
					direccion = 4;
			}
			if (Input.GetKey ("right"))
			{
				if (direccion != 4)
					direccion = 2;
			}
		}

		if (GameObject.Find ("SnakePlaneta1") != null)
		{
			Objetivo = 15;
			if (snakebodylenght == 20)
			{
				NivelCompleto = 1;
			}
		}
		if (GameObject.Find ("SnakePlaneta2") != null)
		{
			Objetivo = 21;
			if (snakebodylenght == 26)
			{
				NivelCompleto = 2;
			}
		}
		if (GameObject.Find ("SnakePlaneta3") != null)
		{
			Objetivo = 27;
			if (snakebodylenght == 32)
			{
				NivelCompleto = 3;
			}
		}
		if (GameObject.Find ("SnakePlaneta4") != null)
		{
			Objetivo = 33;
			if (snakebodylenght == 38)
			{
				NivelCompleto = 4;
			}
		}
		if (GameObject.Find ("SnakePlaneta5") != null)
		{
			Objetivo = 40;
			if (snakebodylenght == 45)
			{
				NivelCompleto = 5;
			}
		}
	}
}
