using UnityEngine;
using System.Collections;

public class BumpyKilly : MonoBehaviour {
	// Use this for initialization
	void Start () {
	
	}
	
	void OnTriggerEnter(Collider other) {
		Destroy(other.gameObject);
		gameObject.SendMessageUpwards ("EnemyKilled", 1,SendMessageOptions.DontRequireReceiver);

	}
}
