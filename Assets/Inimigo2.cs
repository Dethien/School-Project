using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[RequireComponent(typeof(UnityEngine.AI.NavMeshAgent))]
public class Inimigo2 : MonoBehaviour {

	public Transform Player;
	public UnityEngine.AI.NavMeshAgent naveMesh;
	void Start (){
		naveMesh = transform.GetComponent<UnityEngine.AI.NavMeshAgent> ();
	}
	void Update (){
		naveMesh.destination = Player.position;
	}
}