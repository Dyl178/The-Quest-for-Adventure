#pragma strict
public var killed = 0;
function Start () {

}

function OnTriggerEnter(other : Collider) {
		Destroy(other.gameObject);
		var killed = killed - (1);
		print ("enemy killed");
		BroadcastMessage ("EnemyKilled");
		}