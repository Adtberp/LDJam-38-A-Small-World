using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DefenzaDisparo : MonoBehaviour {

	private float DemoraDisparo;
	public GameObject Municion;
	public float CuentaRegresiva;
	private Text CuentaRegresivaUI;

	void Start ()
	{
		if (gameObject.name == "DefenzaCentroArma")
		{
			CuentaRegresiva = 3;
		}
		CuentaRegresivaUI = GameObject.Find ("CuentaRegresiva").GetComponent<Text> ();
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
			DemoraDisparo -= Time.deltaTime;
			if (gameObject.name == "DefenzaDisparo(Clone)" || gameObject.name == "DefenzaDisparo")
			{
				transform.Translate (5 * Time.deltaTime, 0, 0, Space.Self);
				if (Vector2.Distance (gameObject.transform.position, GameObject.Find ("DefenzaArma").transform.position) > 5)
				{
					Destroy (gameObject);
				}
			}
			else
			{
				if (Input.GetKeyDown ("space") && DemoraDisparo <= 0)
				{
					Instantiate (Municion, GameObject.Find ("DefenzaArma").transform.position, transform.rotation);
					DemoraDisparo = 0.3f;
				}

			}
		}
	}
	void OnTriggerEnter2D (Collider2D otro)
	{
		if (gameObject.name == "DefenzaDisparo(Clone)" && otro.tag == "Enemigo")
		{
			Destroy (otro.gameObject);
			Destroy (gameObject);
		}
		if (gameObject.name == "DefenzaCentroArma" && otro.tag == "Enemigo")
		{
			Destroy (gameObject);
		}
	}
}
