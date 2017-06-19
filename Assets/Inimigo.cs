using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[RequireComponent(typeof(UnityEngine.AI.NavMeshAgent))]

public class Inimigo : MonoBehaviour {

	public Transform[] Destinos; // linke os destinos aleatorios aqui
	public GameObject[] Objetos; // linke os objetos aleatorios aqui
	private float cronometro;
	public float tempoPorSpawn;
	public Transform Player;
	public UnityEngine.AI.NavMeshAgent NavMesh;
	public AudioClip Monstro;

	void Start (){
		NavMesh = transform.GetComponent<UnityEngine.AI.NavMeshAgent> ();
	}
		

	void Update (){
			cronometro += Time.deltaTime;
			if (cronometro >= tempoPorSpawn) {
				Instantiate(Objetos[Random.Range (0,Objetos.Length)],Destinos[Random.Range (0,Destinos.Length)].transform.position,transform.rotation);
				cronometro = 0;
			NavMesh.destination = Player.position;
			}
		}
	}