using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Block : MonoBehaviour
{
	private Vector3 targetPos;

	void Start()
	{
		targetPos = transform.position;
	}

	void Update()
	{
		transform.position = new Vector3(Mathf.Sin(Time.time) * 5.0f +  //ˆÚ“®‘¬‚³”ÍˆÍ
			targetPos.x, targetPos.y, targetPos.z);
	}
}
