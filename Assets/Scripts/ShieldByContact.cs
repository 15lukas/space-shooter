/*using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShieldByContact : MonoBehaviour
{
	private GameController gameController;

	void Start ()
	{
		GameObject gameControllerObject = GameObject.FindWithTag ("GameController");
		if (gameControllerObject != null) 
		{
			gameController = gameControllerObject.GetComponent<GameController> ();
		}
		if (gameController == null) 
		{
			Debug.Log ("Cannot find 'GameController' script");
		}
	}

	void OnTriggerEnter(Collider other)
	{
		if (other.tag == "Boundary")
		{
			return;
		}
		if (other.tag == "Player") 
		{
			
		}
		Destroy (other.gameObject);
		Destroy (gameObject);



		if (other.tag == "Player") 
		{
			Destroy (gameObject);

		}


	}
}*/