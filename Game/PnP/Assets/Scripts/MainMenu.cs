using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEditor;
using System.IO;
public class MainMenu : MonoBehaviour {
	public static string path;
	public void PlayGame(){
		if(path == null || path == ""){
			Debug.Log("no path found");
		}
		else{
		SceneManager.LoadScene("Play");
		}
	}
	public void WriteGame(){
		if(path == null || path == ""){
			Debug.Log("no path found");
		}
		else{
			SceneManager.LoadScene("Write");
		}
	}
	public void QuitGame(){
		Debug.Log("QUIT");
		Application.Quit();
	}
	public void PlayLoad(){
		Debug.Log(path);
		path = EditorUtility.OpenFilePanel("Choose main.txt","","txt");
		Debug.Log(path);
		Debug.Log(System.IO.File.ReadAllLines(path)[0]);
		ChangeTextPlayMenu.SetText(System.IO.File.ReadAllLines(path)[0]);
	}
	public void WriteLoad(){
		path = EditorUtility.OpenFilePanel("Choose main.txt","","txt");
	}
}
