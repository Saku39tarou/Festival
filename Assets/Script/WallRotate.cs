using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallRotate : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
		if(Input.GetKeyDown(KeyCode.LeftArrow))
		{
			transform.Rotate(0, 10, 0);
		}
		if(Input.GetKeyDown(KeyCode.RightArrow))
		{
			transform.Rotate(0, -10, 0);
		}
    }
}
