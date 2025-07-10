using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{
	//”à‚ğ“®‚©‚·Œü‚«‚ÌÀ•W
	float defaultY;
	float openY = 5f;
	float speed = 1f;

	public bool isOpen;

	 void Start()
	{
		defaultY = transform.position.y;
	}

	 void Update()
	{
		if(isOpen &&  transform.position.y<openY)
		{
			transform.position += Vector3.up * speed * Time.deltaTime;
		}
		else if(!isOpen && transform.position.y>defaultY)
		{
			transform.position -= Vector3.up * speed * Time.deltaTime;
		}
	}
}
