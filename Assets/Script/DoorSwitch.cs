using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorSwitch : MonoBehaviour
{
	private Vector3 pos;
	private bool stopKey = false;

	void Update()
	{
		pos = transform.position;

		if (!stopKey)
		{
			//����͏�ɊJ��
			transform.Translate(0, 0, 0.01f);//x,y,z����ɓ����l
											 //transform.Translate(0, 0.01f, 0);//x,y,z����ɓ����l
		}

		//�h�A���w�肵�������𒴂�����~�߂�
		if (pos.y > 3f)
		{
			stopKey = true;
		}
	}
}
