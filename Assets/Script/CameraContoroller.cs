using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraContoroller : MonoBehaviour
{
	public float mouseSensitivity = 250f;//Š´“x
	private float xRotation = 0f;//x²‰ñ“]

	private void Update()
	{
		//xã‚ğ‰ñ“]
		float mouseX = Input.GetAxis("Mouse X") * mouseSensitivity * Time.deltaTime;
		
		xRotation = Mathf.Clamp(xRotation, -90f, 90f);//ƒJƒƒ‰‚Ì‰ñ“]‘¬“x

		transform.localRotation = Quaternion.Euler(xRotation, 0f, 0f);
		transform.parent.Rotate(Vector3.up * mouseX);
	}
}
