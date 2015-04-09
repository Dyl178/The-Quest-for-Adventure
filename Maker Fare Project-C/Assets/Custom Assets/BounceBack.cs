using UnityEngine;
using System.Collections;

public class BounceBack : MonoBehaviour {
	
	void EnemyKilled () {
	gameObject.BroadcastMessage("EnemyKilled2");
	}
}
