using UnityEngine;
using System.Collections;

public class Enemyattacks : MonoBehaviour {
	GameObject player;
	void Start () {
		player = GameObject.FindGameObjectWithTag ("Player");
	}

	// Update is called once per frame
	void EHit (Collider hit) {
		if(hit == player){
			BroadcastMessage("SubtractByTwenty");
		}
}
}
