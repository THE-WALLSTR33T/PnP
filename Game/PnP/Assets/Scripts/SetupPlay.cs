using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using System.IO;
public class SetupPlay : MonoBehaviour {
	
	// Use this for initialization
	void Start () {
		string mainPath = MainMenu.pathToMain;
		string[] content = Utilitys.GetInformationTXT(mainPath);
		Char char = new Char("I:/info/privat/unity/PnP/Example/PC/PC_1.txt");
	}	
	// Update is called once per frame
	void Update () {
		
	}
}
