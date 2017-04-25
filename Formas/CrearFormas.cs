using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CrearFormas : MonoBehaviour {

	public float InvocarForma;
	public GameObject[] Formas;
	public float ValorCuenta;
	private float CuentaRegresiva;
	private Text CuentaRegresivaUI;

	void Start ()
	{
		CuentaRegresivaUI = GameObject.Find ("CuentaRegresiva").GetComponent<Text> ();
		InvocarForma = 1;
		CuentaRegresiva = 3;
	}
	
	void Update ()
	{
		if (CuentaRegresiva > 0)
		{
			CuentaRegresiva -= Time.deltaTime;
			CuentaRegresivaUI.text = CuentaRegresiva.ToString ("F1");
		}
		if (CuentaRegresiva <= 0)
		{
			CuentaRegresivaUI.text = " ";
		
			InvocarForma -= Time.deltaTime;
			if (GameObject.Find ("FormasNivel1(Clone)"))
			{
				ValorCuenta = 1.5f;
			}
			if (GameObject.Find ("FormasNivel2(Clone)"))
			{
				ValorCuenta = 1.3f;
			}
			if (GameObject.Find ("FormasNivel3(Clone)"))
			{
				ValorCuenta = 1.1f;
			}
			if (GameObject.Find ("FormasNivel4(Clone)"))
			{
				ValorCuenta = 0.9f;
			}
			if (GameObject.Find ("FormasNivel5(Clone)"))
			{
				ValorCuenta = 0.9f;
			}
			if (GameObject.Find ("BordeFormas5"))
			{
				if (InvocarForma <= 0)
				{
					Instantiate (Formas [UnityEngine.Random.Range (0, Formas.Length)], transform.position, Quaternion.identity);
					InvocarForma = ValorCuenta;
				}
			}
			if (GameObject.Find ("BordeFormas4"))
			{
				if (InvocarForma <= 0)
				{
					Instantiate (Formas [UnityEngine.Random.Range (0, Formas.Length - 1)], transform.position, Quaternion.identity);
					InvocarForma = ValorCuenta;
				}
			}
			if (GameObject.Find ("BordeFormas3"))
			{
				if (InvocarForma <= 0)
				{
					Instantiate (Formas [UnityEngine.Random.Range (0, Formas.Length - 2)], transform.position, Quaternion.identity);
					InvocarForma = ValorCuenta;
				}
			}
		}
	}
}