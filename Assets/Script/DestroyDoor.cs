using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyDoor : MonoBehaviour
{
	public GameObject Door;
	// Update is called once per frame
	private void OnCollisionEnter(Collision collision)//衝突したら・・・
	{
		if (collision.gameObject.CompareTag("Player"))
		{

			Destroy(Door, 3.0f);
			Debug.Log("扉開いた");

		}
	}
}
