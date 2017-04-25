using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ControlAuto : MonoBehaviour {

	public int CheckPoints;
	public float Velocidad;
	public bool Corriendo;
	public int NivelCompleto;
	public float Tiempo;
	private float CuentaRegresiva;
	private bool Completo;
	private Text CuentaRegrsivaTexto;
	private Text TiempoTexto;
	private Text TiempoObjetivo;
	private Text Objetivo;
	private Text TextoTiempo;

	void Start ()
	{
		TextoTiempo=GameObject.Find ("Puntaje").GetComponent<Text> ();
		Objetivo=GameObject.Find ("PuntajeObjetivo").GetComponent<Text> ();
		TiempoObjetivo=GameObject.Find ("PuntajeNivel").GetComponent<Text> ();
		TiempoTexto = GameObject.Find ("PuntajeMiniJuego").GetComponent<Text> ();
		CuentaRegrsivaTexto = GameObject.Find ("CuentaRegresiva").GetComponent<Text> ();
		Completo = false;
		CuentaRegresiva = 3;
		Corriendo = false;
		CheckPoints = 0;
		Velocidad = 1.7f;
	}
	
	void Update ()
	{
		TextoTiempo.text = "   Time :";
		Objetivo.text = "Time To Beat:";
		if (GameObject.Find ("Pista1(Clone)"))
		{
			TiempoObjetivo.text = "9.1 Sec";
		}
		if (GameObject.Find ("Pista2(Clone)"))
		{
			TiempoObjetivo.text = "14.5 Sec";
		}
		if (GameObject.Find ("Pista3(Clone)"))
		{
			TiempoObjetivo.text = "9.7 Sec";
		}
		if (GameObject.Find ("Pista4(Clone)"))
		{
			TiempoObjetivo.text = "18.3 Sec";
		}
		if (GameObject.Find ("Pista5(Clone)"))
		{
			TiempoObjetivo.text = "17 Sec";
		}
		TiempoTexto.text = Tiempo.ToString ("F2");
		if (CuentaRegresiva > 0 && Completo == false)
		{
			CuentaRegrsivaTexto.text = CuentaRegresiva.ToString ("F1");
			CuentaRegresiva -= Time.deltaTime;
		}
		if (CuentaRegresiva <= 0 && Completo == false)
		{
			CuentaRegrsivaTexto.text = " ";
			Corriendo = true;
		}
		if (Corriendo)
		{
			if (Input.GetKey ("up"))
			{
				if (Input.GetKey ("left"))
				{
					transform.Rotate (new Vector3 (0, 0, +180 * Time.deltaTime), Space.Self);
				}
				if (Input.GetKey ("right"))
				{
					transform.Rotate (new Vector3 (0, 0, -180 * Time.deltaTime), Space.Self);
				}
				transform.Translate (new Vector2 (+Velocidad * Time.deltaTime, 0));
			}
			if (Input.GetKey ("down"))
			{
				if (Input.GetKey ("left"))
				{
					transform.Rotate (new Vector3 (0, 0, -240 * Time.deltaTime), Space.Self);
				}
				if (Input.GetKey ("right"))
				{
					transform.Rotate (new Vector3 (0, 0, +240 * Time.deltaTime), Space.Self);
				}
				transform.Translate (new Vector2 (-Velocidad * Time.deltaTime, 0));
			}
			Tiempo += Time.deltaTime;
			if (Tiempo >= 80)
			{
				NivelCompleto = -1;
			}
		}
	}
	void OnTriggerEnter2D (Collider2D otro)
	{		
		if (otro.gameObject.name == "Checkpoint")
		{
			CheckPoints += 1;
			otro.gameObject.name = "Check";
		}
		if (otro.gameObject.name == "Meta")
		{
			if (GameObject.Find ("Pista1(Clone)") != null && CheckPoints == 3)
			{
				Corriendo = false;
				Completo = true;
				if (Tiempo <= 9.1f)
				{
					NivelCompleto = 1;
				}
				else
				{
					NivelCompleto = -1;
				}
			}
			if (GameObject.Find ("Pista2(Clone)") != null && CheckPoints == 3)
			{
				Corriendo = false;
				Completo = true;
				if (Tiempo <= 14.5f)
				{
					NivelCompleto = 2;
				}
				else
				{
					NivelCompleto = -1;
				}
			}
			if (GameObject.Find ("Pista3(Clone)") != null && CheckPoints == 3)
			{
				Corriendo = false;
				Completo = true;
				if (Tiempo <= 9.7f)
				{
					NivelCompleto = 3;
				}
				else
				{
					NivelCompleto = -1;
				}
			}
			if (GameObject.Find ("Pista4(Clone)") != null && CheckPoints == 4)
			{
				Corriendo = false;
				Completo = true;
				if (Tiempo <= 18.3f)
				{
					NivelCompleto = 4;
				}
				else
				{
					NivelCompleto = -1;
				}
			}
			if (GameObject.Find ("Pista5(Clone)") != null && CheckPoints == 4)
			{
				Corriendo = false;
				Completo = true;
				if (Tiempo <= 17)
				{
					NivelCompleto = 5;
				}
				else
				{
					NivelCompleto = -1;
				}
			}
		}
	}
	void OnTriggerStay2D (Collider2D otro)
	{
		if (otro.gameObject.name == "Pasto")
		{
			Velocidad = 0.7f;
		}
	}
	void OnTriggerExit2D (Collider2D otro)
	{
		if (otro.gameObject.name == "Pasto")
		{
			Velocidad = 1.7f;
		}
	}
}