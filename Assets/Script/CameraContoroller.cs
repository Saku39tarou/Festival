using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraContoroller : MonoBehaviour
{
	public float mouseSensitivity = 250f;//感度
	private float xRotation = 0f;//x軸回転

	private void Update()
	{
		//x上を回転
		float mouseX = Input.GetAxis("Mouse X") * mouseSensitivity * Time.deltaTime;
		
		xRotation = Mathf.Clamp(xRotation, -90f, 90f);//カメラの回転速度

		transform.localRotation = Quaternion.Euler(xRotation, 0f, 0f);
		transform.parent.Rotate(Vector3.up * mouseX);
	}
}
