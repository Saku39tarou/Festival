using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorOpen4 : MonoBehaviour
{
	public GameObject door;

	private void OnTriggerEnter(Collider other)
	{
		if (other.CompareTag("Item"))
		{
			door.GetComponent<DoorSwitch2>().enabled = true;

			this.gameObject.SetActive(false);
		}
	}
}
