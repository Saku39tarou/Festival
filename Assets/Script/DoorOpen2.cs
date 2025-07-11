using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorOpen2 : MonoBehaviour
{
	public GameObject door;

	private void OnTriggerEnter(Collider other)
	{
		if (other.CompareTag("Player"))
		{
			door.GetComponent<DoorSwitch>().enabled = true;

			this.gameObject.SetActive(false);
		}
	}
}
