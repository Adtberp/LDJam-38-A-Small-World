using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RpgPlayerMainScript : MonoBehaviour {

	private Rigidbody2D Rig;
	private float tempPosX = 0;
	private float tempPosY = 0;
	private float asdX = 0;
	private float asdY = 0;
	private Animator Anim;
	public GameObject escudo;
	public int Vida;
	private GameObject espadazo;
	public GameObject espada;
	private Slider VidaUI;
	public int NivelCompleto;
	private Text CuentaRegresivaUI;
	private float CuentaRegresiva;

	void Start () 
	{
		CuentaRegresivaUI = GameObject.Find ("CuentaRegresiva").GetComponent<Text> ();
		CuentaRegresiva = 3;
		VidaUI = GameObject.Find ("SliderVida").GetComponent<Slider> ();
		Vida = 5;
		Rig = GetComponent<Rigidbody2D> ();
		Anim = GetComponent<Animator> ();
		VidaUI.maxValue = Vida;
	}
	
	void Update ()
	{
		VidaUI.value = Vida;
		if (Vida <= 0)
		{
			NivelCompleto = -1;
			Destroy (gameObject);
		}
		if (CuentaRegresiva > 1 && CuentaRegresiva < 2)
		{
			tempPosX = transform.position.x;
			tempPosY = transform.position.y;
		}
		if (CuentaRegresiva > 0)
		{
			CuentaRegresivaUI.text = CuentaRegresiva.ToString ("F1");
			CuentaRegresiva -= Time.deltaTime;
		}
		if (CuentaRegresiva <= 0 && GameObject.Find ("RPGPuerta").GetComponent<RPGNivelCompleto> ().NivelCompleto == 0)
		{
			CuentaRegresivaUI.text = " ";
			if (asdX == tempPosX & asdY == tempPosY)
			{
				Anim.SetBool ("Caminando", false);
				if (Input.GetKey ("space"))
				{
					Anim.SetBool ("Defendiendo", true);
					//escudo.transform.position = new Vector3 ( transform.position.y, 0.17f, transform.position.z);
					//escudo.transform.rotation = Quaternion.Euler (new Vector3 (0, 0, 90));
				}
				else
				{
					Anim.SetBool ("Defendiendo", false);
					//escudo.transform.position = new Vector3 ( transform.position.y, transform.position.y, transform.position.z);
					//escudo.transform.rotation = Quaternion.Euler (new Vector3 (0, 0, 0));
					if (Input.GetKey ("up"))
					{
						tempPosY = transform.position.y + 0.16f;
						transform.rotation = Quaternion.Euler (new Vector3 (0, 0, 0));

					}
					if (Input.GetKey ("down"))
					{
						tempPosY = transform.position.y - 0.16f;
						transform.rotation = Quaternion.Euler (new Vector3 (0, 0, 180));

					}
					if (Input.GetKey ("left"))
					{
						tempPosX = transform.position.x - 0.16f;
						transform.rotation = Quaternion.Euler (new Vector3 (0, 0, 90));
					}
					if (Input.GetKey ("right"))
					{
						tempPosX = transform.position.x + 0.16f;
						transform.rotation = Quaternion.Euler (new Vector3 (0, 0, -90));
					}
				}
			}
			else
			{
				Anim.SetBool ("Caminando", true);
			}

			asdX = Mathf.MoveTowards (transform.position.x, tempPosX, 0.03f);
			asdY = Mathf.MoveTowards (transform.position.y, tempPosY, 0.03f);
			Rig.transform.position = new Vector3 (asdX, asdY, transform.position.z);

			if (Input.GetKeyDown ("s"))
			{
				espadazo = Instantiate (espada, new Vector3 (transform.position.x, transform.position.y, transform.position.y), transform.rotation);
				espadazo.transform.parent = gameObject.transform;
				espadazo.transform.localPosition = new Vector3 (0.048f, 0.038f, 0);
			}
		}
	}
	void OnTriggerEnter2D (Collider2D otro)
	{
		if (otro.gameObject.name == "RPGArrow(Clone)")
		{
			Vida -= 1;
			Destroy (otro.gameObject);
		}
		if (otro.gameObject.name == ("RPGPuerta")) 
		{
			if (GameObject.Find ("RPGPlaneta1") != null)
			{
				NivelCompleto = 1;
			}
			if (GameObject.Find ("RPGPlaneta2") != null)
			{
				NivelCompleto = 2;
			}
			if (GameObject.Find ("RPGPlaneta3") != null)
			{
				NivelCompleto = 3;
			}
			if (GameObject.Find ("RPGPlaneta4") != null)
			{
				NivelCompleto = 4;
			}
			if (GameObject.Find ("RPGPlaneta5") != null)
			{
				NivelCompleto = 5;
			}
		}
	}
}
