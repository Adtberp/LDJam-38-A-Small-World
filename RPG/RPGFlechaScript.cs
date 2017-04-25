using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RPGFlechaScript : MonoBehaviour {

	private GameObject player;
	private Rigidbody2D Rig;
	private float varx = 0;
	private float vary = 0;
	private Vector3 v31;
	private Vector3 v32;

	void Start ()
	{
		Destroy (gameObject, 2);
		player = GameObject.Find ("RPGPlayer");
		Rig = GetComponent<Rigidbody2D> ();
		varx = player.transform.position.x;
		vary = player.transform.position.y;
	

		v31 = player.transform.position;
		v32 = v31 - gameObject.transform.position;
		float angulo = Mathf.Atan2 (v32.y, v32.x) * Mathf.Rad2Deg;
		transform.rotation = Quaternion.AngleAxis (angulo, Vector3.forward);
	}

	void OnTriggerEnter2D (Collider2D other)
	{
		if (other.gameObject.name == "Escudo" || other.gameObject.name == "RPGTerrainOne"|| other.gameObject.name == "RPGTerrainTwo"|| other.gameObject.name == "RPGTerrainThree"|| other.gameObject.name == "RPGTerrainFour"|| other.gameObject.name == "RPGTerrainFive") 
		{
			//asd += 1;
			Destroy (gameObject);
		}
	}

	void Update () 
	{
		//if (transform.position.x == varx && transform.position.y == vary)
			//Destroy (gameObject);

		Rig.transform.position = Vector3.MoveTowards (transform.position, new Vector3 (varx, vary, 0f), 0.06f);
	}
}
