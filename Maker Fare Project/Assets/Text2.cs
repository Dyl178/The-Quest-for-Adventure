using UnityEngine;
using System.Collections;

public class Text2 : MonoBehaviour {
	public string stringToEdit = "Hello World";
	// Use this for initialization
	void Start () {
	
	}
	
	void OnGUI() {
		stringToEdit = GUI.TextField (new Rect (750, 20, 250, 20), stringToEdit, 42);
	}
}