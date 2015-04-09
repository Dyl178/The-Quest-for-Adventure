using UnityEngine;
using System.Collections;

public class text : MonoBehaviour {

	// Use this for initialization
	void Start () {
		}
	       private bool isClicked = false;
			public string stringToEdit = "Hello World";
			void OnGUI() {
				stringToEdit = GUI.TextField (new Rect (100, 10, 220, 20), stringToEdit, 25);
				if (GUI.Button (new Rect (90, 40, 50, 30), "Next")) {
						Debug.Log ("Clicked the button with text");	
						isClicked = true;
				}
		}
	void DoSomething(){
		if (isClicked) {
			stringToEdit = "Use W,A,S,D to move around, try it!";
			isClicked = false;	
		}
	}
		
}

