using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
public class SetupWrite : MonoBehaviour {
	
	// Use this for initialization
	void Start () {
		string mainPath = MainMenu.path;
		string[] content = System.IO.File.ReadAllLines(mainPath);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
