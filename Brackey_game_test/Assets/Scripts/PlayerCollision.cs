using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
	public PlayerMovement movement;

	void OnCollisionEnter(Collision collisionInfo)
	{
		if (collisionInfo.collider.tag == "Kasse")
		{
			movement.enabled = false;
			FindObjectOfType<GameManager>().EndGame();
			//Debug.Log("Ramte en Kasse");
		}


	}

	//void OnTriggerEnter(Collision collisionInfo)
	//{
	//	if (collisionInfo.collider.tag == "End")
	//	{
	//		//movement.enabled = false;
	//		FindObjectOfType<GameManager>().CompleteLevel();
	//		//Debug.Log("Ramte en Kasse");
	//	}
	//}
}