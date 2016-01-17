using UnityEngine;
using System.Collections;

public class GibOnTriggers : MonoBehaviour {


	public GameObject gib;

	void OnTriggerEnter()
	{
		Instantiate (gib, transform.position, Quaternion.identity);
		Destroy (gameObject);

	}



}
