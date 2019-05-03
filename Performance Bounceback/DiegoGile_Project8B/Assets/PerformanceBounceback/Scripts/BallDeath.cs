using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallDeath : MonoBehaviour {

	void OnCollisionEnter(Collision coli)
	{
		if(coli.gameObject.CompareTag("Ground"))
		{
			this.gameObject.SetActive(false);
		}
	}
}
