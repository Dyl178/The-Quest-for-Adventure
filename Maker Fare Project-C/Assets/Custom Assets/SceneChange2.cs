using UnityEngine;
using System.Collections;

public class SceneChange2 : MonoBehaviour {

	void OnTriggerEnter(Collider other){
		Application.LoadLevel ("L3");
	}
}