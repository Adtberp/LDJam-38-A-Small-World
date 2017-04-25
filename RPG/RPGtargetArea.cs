using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RPGtargetArea : MonoBehaviour {
	

	void Start () 
	{
	}
	
	void OnTriggerEnter2D (Collider2D other)
	{
		if (other.gameObject.name == "RPGPlayer")
			this.transform.parent.GetComponent<RPGEnemyScript> ().playerInArea = true;
	}
	void OnTriggerExit2D (Collider2D other)
	{
		if (other.gameObject.name == "RPGPlayer")
			this.transform.parent.GetComponent<RPGEnemyScript> ().playerInArea = false;
			
	}
	
	void Update () 
	{
		
	}
}
