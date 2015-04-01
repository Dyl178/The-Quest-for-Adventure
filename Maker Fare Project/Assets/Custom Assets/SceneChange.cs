using UnityEngine;
using System.Collections;
public class SceneChange : MonoBehaviour {
	public int enemyKills = 6;
	void Start(){

		}
	void EnemyKilled2 () {
		Debug.Log (enemyKills);
		enemyKills = subtractbyone(enemyKills);
	}
	int subtractbyone (int number)
	{
		int ret;
		ret = enemyKills - 1; 
		return ret;
	}
	void OnTriggerEnter(Collider Player){
						Application.LoadLevel ("L2");
						print ("LevelLoaded2");
				}
		}
