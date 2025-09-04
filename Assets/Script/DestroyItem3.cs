using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyItem3 : MonoBehaviour
{
	public GameObject Item;
	public GameObject Door;
	public AudioClip myClip;
	// Update is called once per frame
	private void OnCollisionEnter(Collision collision)//衝突したら・・・
	{
		if (collision.gameObject.CompareTag("Switch3"))
		{

			Destroy(Item, 1.0f);
			Destroy(Door, 1.0f);
			Debug.Log("扉開いた");
			AudioSource.PlayClipAtPoint(myClip, transform.position);
		}
	}
}
