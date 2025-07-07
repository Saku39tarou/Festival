using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorOpen : MonoBehaviour
{
	public GameObject door;

	private void OnTriggerEnter(Collider other)
	{
		if(other.CompareTag("Player"))
		{
			door.GetComponent<DoorMove>().enabled = true;

			this.gameObject.SetActive(false);
		}
	}
}
