using UnityEngine;
using System.Collections;
using UnityEngine;

public class LifePlayer : MonoBehaviour {
	
	public static float life = 100;
	void Update (){
		if (life <= 0) {
			Debug.Log ("morreu");
		}
	}
}