using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Text.RegularExpressions;
using UnityEngine.Windows;

public class ChangeBGPlayMenu : MonoBehaviour {

	static RawImage rawimage;
	static Texture2D Background;
	static byte[] fullpath;
	
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	
	public static void SetBackground(string path, string pathToBG){
		GameObject image = GameObject.Find("Background_Image_PlayMenu");
		rawimage = image.GetComponent<RawImage>();

		fullpath = File.ReadAllBytes(Regex.Replace(pathToBG,"^BG = ",path));

		Background = new Texture2D(1, 1);
		Background.LoadImage(fullpath);

		float alpha = 1.0f; //1 is opaque, 0 is transparent
 		Color currColor = rawimage.color;
 		currColor.a = alpha;
 		rawimage.color = currColor;

		rawimage.texture = Background;
		rawimage.color = currColor;
		
	}
}
