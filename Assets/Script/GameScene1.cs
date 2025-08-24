using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameScene1 : MonoBehaviour
{
	public void change_button()
	{
		//Time.timeScale = 1f;
		this.gameObject.SetActive(false);
		SceneManager.LoadScene("GameScene");
		//ScoreManager.score = 0;//ƒXƒRƒA‚Ì‰Šú‰»‚ğ‚·‚é
	}
}
