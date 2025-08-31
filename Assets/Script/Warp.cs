using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Warp : MonoBehaviour
{
	public Vector3 pos;//position
	public AudioClip myClip;

	private void OnTriggerEnter(Collider other)
	{
		other.gameObject.transform.position = pos;//ˆÚ“®‚·‚é’n“_‚ğunity‘¤‚Åİ’è
		AudioSource.PlayClipAtPoint(myClip, transform.position);
	
	
		if (other.CompareTag("Player"))
		{
			AudioSource.PlayClipAtPoint(myClip, transform.position);
		}
	}
}
