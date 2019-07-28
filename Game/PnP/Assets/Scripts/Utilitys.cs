using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
public class Utilitys : MonoBehaviour {
	public static string[] GetInformationTXT(string path){
		return System.IO.File.ReadAllLines(path);
	}
}
