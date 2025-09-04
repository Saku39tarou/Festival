using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseMenu : MonoBehaviour
{
	//ポーズしたときに表示するUI
	[SerializeField] private GameObject Panel;
	

	// Update is called once per frame
	void Update()
	{

		if (Input.GetKeyDown(KeyCode.Space))
		{
			//ポーズUIのアクティブ、非アクティブを切り替え
			Panel.SetActive(!Panel.activeSelf);

			//ポーズUIが表示されてるときは禁止
			if (Panel.activeSelf)
			{
				Time.timeScale = 0f;
			}

			//ポーズUIが表示されてなければ通常通り進行
			else
			{
				Time.timeScale = 1f;//解除
			}
			if (Mathf.Approximately(Time.timeScale, 0f))
			{
				return;
			}
		}

	}
}
