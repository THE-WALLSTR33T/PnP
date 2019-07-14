﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour {

	public void PlayGame(){
		SceneManager.LoadScene("Play");
	}
	public void WriteGame(){
		SceneManager.LoadScene("Write");
	}
	public void QuitGame(){
		Debug.Log("QUIT");
		Application.Quit();
	}
}
