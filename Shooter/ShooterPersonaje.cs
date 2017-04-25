using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShooterPersonaje : MonoBehaviour {

	private Vector3 Mira;
	private float diferencia;
	private bool Caminando;
	public GameObject Disparo;
	private float Demora;
	public int Vida;
	private float TiempoInv;
	public int NivelCompleto;
	private Slider VidaUI;
	public float CuentaRegresiva;
	private Text CuentaRegresivaUI;

	void Start ()
	{
		CuentaRegresiva = 3;
		CuentaRegresivaUI = GameObject.Find ("CuentaRegresiva").GetComponent<Text> ();
		VidaUI = GameObject.Find ("SliderVida").GetComponent<Slider> ();
		Vida = 5;
	}
	
	void Update ()
	{
		if (CuentaRegresiva > 0)
		{
			CuentaRegresiva -= Time.deltaTime;
			CuentaRegresivaUI.text = CuentaRegresiva.ToString ("F1");
		}
		VidaUI.maxValue = 5;
		VidaUI.value = Vida;
		if (Vida <= 0)
		{
			Destroy (gameObject);
		}
		if (TiempoInv >= 0)
		{
			TiempoInv -= Time.deltaTime;
		}
		Demora -= Time.deltaTime;
		if (CuentaRegresiva <= 0)
		{
			CuentaRegresivaUI.text = " ";
			if (Input.GetKey ("up"))
			{
				transform.Translate (0, +1.1f * Time.deltaTime, 0, Space.World);
				Caminando = true;
			}
			if (Input.GetKey ("down"))
			{
				transform.Translate (0, -1.1f * Time.deltaTime, 0, Space.World);
				Caminando = true;
			}
			if (Input.GetKey ("left"))
			{
				transform.Translate (-1.1f * Time.deltaTime, 0, 0, Space.World);
				Caminando = true;
			}
			if (Input.GetKey ("right"))
			{
				transform.Translate (+1.1f * Time.deltaTime, 0, 0, Space.World);
				Caminando = true;
			}
			if (Input.GetKeyUp ("right") || Input.GetKeyUp ("left") || Input.GetKeyUp ("down") || Input.GetKeyUp ("up"))
			{
				Caminando = false;
			}
			if (Input.GetMouseButton (0) && Demora <= 0)
			{
				Instantiate (Disparo, transform.TransformPoint (0.04f, -0.05f, 0), transform.rotation);
				Demora = 0.4f;
			}
			gameObject.GetComponent<Animator> ().SetBool ("Caminando", Caminando);
			Mira = Camera.main.ScreenToWorldPoint (Input.mousePosition) - transform.position;
			diferencia = Mathf.Atan2 (Mira.y, Mira.x) * Mathf.Rad2Deg;
			transform.rotation = Quaternion.AngleAxis (diferencia, Vector3.forward);
		}
	}
	void OnCollisionStay2D (Collision2D otro)
	{
		if (otro.gameObject.tag == "Enemigo" && TiempoInv <= 0)
		{
			Vida -= 1;
			TiempoInv = 0.5f;
		}
	}
}