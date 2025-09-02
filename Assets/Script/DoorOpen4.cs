using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorOpen4 : MonoBehaviour
{
	public GameObject door;

	private void OnTriggerEnter(Collider other)
	{
		if (other.CompareTag("Item2"))
		{
			Destroy(door, 1.0f);
			door.GetComponent<DoorSwitch>().enabled = true;

			this.gameObject.SetActive(false);
		}
	}
}
