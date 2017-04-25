using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GiroFormasContorno : MonoBehaviour {

	public int Vida;
	public int Puntos;
	private Text PuntosTexto;
	private Text PuntajeTexto;
	private Text PuntosObjetivo;
	private Text PuntajeObjetivo;
	public int NivelCompleto;
	private Slider VidaUI;

	void Start ()
	{
		VidaUI = GameObject.Find ("SliderVida").GetComponent<Slider> ();
		PuntajeObjetivo = GameObject.Find ("PuntajeObjetivo").GetComponent<Text> ();
		PuntosObjetivo = GameObject.Find ("PuntajeNivel").GetComponent<Text> ();
		PuntajeTexto = GameObject.Find ("Puntaje").GetComponent<Text> ();
		PuntosTexto = GameObject.Find ("PuntajeMiniJuego").GetComponent<Text> ();
		Vida = 3;
	}

	void Update ()
	{
		VidaUI.maxValue = 3;
		VidaUI.value = Vida;
		PuntosTexto.text = Puntos.ToString ();
		PuntajeTexto.text = "  Score :";
		PuntajeObjetivo.text = "  Score To Beat :";
		if (GameObject.Find ("FormasNivel1") != null || GameObject.Find ("FormasNivel1(Clone)") != null)
		{
			PuntosObjetivo.text = "10";
			if (Puntos == 10)
			{
				NivelCompleto = 1;
			}
		}
		if (GameObject.Find ("FormasNivel2") != null || GameObject.Find ("FormasNivel2(Clone)") != null)
		{
			PuntosObjetivo.text = "12";
			if (Puntos == 12)
			{
				NivelCompleto = 2;
			}
		}
		if (GameObject.Find ("FormasNivel3") != null || GameObject.Find ("FormasNivel3(Clone)") != null)
		{
			PuntosObjetivo.text = "15";
			if (Puntos == 15)
			{
				NivelCompleto = 3;
			}
		}
		if (GameObject.Find ("FormasNivel4") != null || GameObject.Find ("FormasNivel4(Clone)") != null)
		{
			PuntosObjetivo.text = "20";
			if (Puntos == 20)
			{
				NivelCompleto = 4;
			}
		}
		if (GameObject.Find ("FormasNivel5") != null || GameObject.Find ("FormasNivel5(Clone)") != null)
		{
			PuntosObjetivo.text = "25";
			if (Puntos == 25)
			{
				NivelCompleto = 5;
			}
		}
		if (Vida == 0 && GameObject.Find ("CreadorFormas") != null)
		{
			GameObject.Find ("CreadorFormas").SetActive (false);
			NivelCompleto = -1;
		}
		if (gameObject.name == "BordeFormas5")
		{
			if (Input.GetKeyDown ("left"))
			{
				transform.Rotate (0, 0, +72);
			}
			if (Input.GetKeyDown ("right"))
			{
				transform.Rotate (0, 0, -72);
			}
		}
		if (gameObject.name == "BordeFormas4")
		{
			if (Input.GetKeyDown ("left"))
			{
				transform.Rotate (0, 0, +90);
			}
			if (Input.GetKeyDown ("right"))
			{
				transform.Rotate (0, 0, -90);
			}
		}
		if (gameObject.name == "BordeFormas3")
		{
			if (Input.GetKeyDown ("left"))
			{
				transform.Rotate (0, 0, +120);
			}
			if (Input.GetKeyDown ("right"))
			{
				transform.Rotate (0, 0, -120);
			}
		}
	}
}
