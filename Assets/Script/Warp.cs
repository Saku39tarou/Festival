using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Warp : MonoBehaviour
{
	public Vector3 pos;//position
	

	private void OnTriggerEnter(Collider other)
	{
		other.gameObject.transform.position = pos;//移動する地点をunity側で設定
	}
}
