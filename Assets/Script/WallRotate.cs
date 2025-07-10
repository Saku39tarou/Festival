using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallRotate : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
		if(Input.GetKeyDown(KeyCode.T))
		{
			transform.Rotate(0, 5, 0);
		}
    }
}
