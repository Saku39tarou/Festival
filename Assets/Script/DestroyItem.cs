using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class DestroyItem : MonoBehaviour
{
	public GameObject Item;
	// Update is called once per frame
	private void OnCollisionEnter(Collision collision)//衝突したら・・・
	{
		if (collision.gameObject.CompareTag("Switch"))
		{
			
			Destroy(Item, 3.0f);
			Debug.Log("扉開いた");

		}
	}
}
