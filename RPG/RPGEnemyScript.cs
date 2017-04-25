using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RPGEnemyScript : MonoBehaviour {

	public GameObject flecha;
	private int atkclddown = 50;
	private Vector3 v31;
	private Vector3 v32;
	private GameObject player;
	public bool playerInArea = false;
	public int vida = 3;

	void Start () 
	{
		player = GameObject.Find ("RPGPlayer");
	}
	
	void OnTriggerEnter2D (Collider2D other)
	{
		if (other.gameObject.name == "RPGSword(Clone)")
			vida -= 1;
	}

	void FixedUpdate () 
	{
		if (vida <= 0)
			Destroy (gameObject);


		if (playerInArea && GameObject.Find ("RPGPuerta").GetComponent<RPGNivelCompleto> ().NivelCompleto == 0)
		{
			atkclddown += 1;
			if (atkclddown == 60) {
				Instantiate (flecha, new Vector3 ((transform.position.x + 0.04f), (transform.position.y - 0.08f), transform.position.z), transform.rotation);
				atkclddown = 0;
			}



			v31 = player.transform.position;
			v32 = v31 - gameObject.transform.position;
			float angulo = Mathf.Atan2 (v32.y, v32.x) * Mathf.Rad2Deg;
			transform.rotation = Quaternion.AngleAxis ((angulo - 90), Vector3.forward);
		}

	}
}
