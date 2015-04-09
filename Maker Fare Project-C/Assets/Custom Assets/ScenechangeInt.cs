using UnityEngine;
using System.Collections;

public class ScenechangeInt : MonoBehaviour {

	void OnTriggerEnter(Collider other){
		Application.LoadLevel ("L1");
	}
}