using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEditor;
using System.IO;
//using System.Linq;
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
	public void PlayLoad(){
		string path = EditorUtility.OpenFilePanel("Choose main.txt","","txt");
		Debug.Log(path);
		Debug.Log(System.IO.File.ReadAllLines(path)[0]);
		//Debug.Log(Resources.Load(path));
	}
	public void WriteLoad(){
		Debug.Log(EditorUtility.OpenFilePanel("Choose main.txt","","txt"));
	}
}
