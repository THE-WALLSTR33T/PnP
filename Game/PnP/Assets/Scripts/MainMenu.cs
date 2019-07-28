using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEditor;
using System.IO;
public class MainMenu : MonoBehaviour {
	public static string path;
	public static string pathToMain;
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
		Debug.Log("path: " + path);
		path = EditorUtility.OpenFolderPanel("Choose main folder","","");
		pathToMain = path + "/main.txt";
		Debug.Log("path: " + path);
		Debug.Log("mainpath: " + pathToMain);
		Debug.Log("name: " + Utilitys.GetInformationTXT(pathToMain)[0]);
		ChangeTextPlayMenu.SetText(Utilitys.GetInformationTXT(pathToMain)[0]);
		ChangeBGPlayMenu.SetBackground(path, Utilitys.GetInformationTXT(pathToMain)[1]);
	}
	public void WriteLoad(){
		path = EditorUtility.OpenFolderPanel("Choose main folder","","");
	}
}
