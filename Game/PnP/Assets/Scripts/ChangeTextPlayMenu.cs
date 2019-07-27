using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class ChangeTextPlayMenu : MonoBehaviour {
	public static TextMeshProUGUI textMeshPro;
	
	// Use this for initialization

	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	void Awake() {
		textMeshPro = GetComponent<TextMeshProUGUI>();
		textMeshPro.text = "Load a folder to play!";
	}
	public static void SetText(string value){
		textMeshPro.text = value;
	}

}
