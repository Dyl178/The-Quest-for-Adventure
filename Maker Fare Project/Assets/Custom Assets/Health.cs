using UnityEngine;
using System.Collections;

public class Health : MonoBehaviour {
	public int PH = 100;
	public int Damage = 20;
	void SubtractByTwenty (){
		int b = PH - Damage;
	}
}

