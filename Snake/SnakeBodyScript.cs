using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SnakeBodyScript : MonoBehaviour {

	private int count = 0;
	private int countcount = 0;
	private BoxCollider2D col;

	void Start () 
	{
		col = GetComponent<BoxCollider2D> ();
	}
	
	void Update () 
	{
		countcount += 1;
		if (countcount == 12)
		{
			count += 1;
			if (count == 1) 
			{
				col.isTrigger = true;
			}

			if (count == SnakeMainScript.snakebodylenght) 
			{
				Destroy (gameObject);
			}
			countcount = 0;
			
		}
	}
}
