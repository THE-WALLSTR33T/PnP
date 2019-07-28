using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Char
{
	public void Char(string path){
		string[] text=GetInformationTXT(path);
		Debug.Log(text[1]);
	}
}
