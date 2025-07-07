using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class DoorMove : MonoBehaviour
{
	private Vector3 pos;
	private bool stopKey = false;

	 void Update()
	{
		pos = transform.position;
		
		if(!stopKey)
		{
			//今回は上に開く
			transform.Translate(0, 0.01f, 0);//x,y,z軸上に動く値
		}

		//ドアが指定した高さを超えたら止める
		if(pos.y>3f)
		{
			stopKey = true;
		}
	}
}
