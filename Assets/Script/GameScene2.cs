using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameScene2 : MonoBehaviour
{
	public void change_button()
	{
		this.gameObject.SetActive(false);
		SceneManager.LoadScene("TimeScene");
	}
}
