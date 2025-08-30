using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class DestroyItem : MonoBehaviour
{
	public GameObject Item;
	public GameObject Door;
	// Update is called once per frame
	private void OnCollisionEnter(Collision collision)//衝突したら・・・
	{
		if (collision.gameObject.CompareTag("Switch"))
		{
			
			Destroy(Item, 1.0f);
			Destroy(Door, 5.0f);
			Debug.Log("扉開いた");
 
		}
	}
}
