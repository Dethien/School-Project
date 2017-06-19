using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lanterna : MonoBehaviour {

	public Light Flashlight;
	public float powerLevel = 440.0f;

	void Start (){
		Flashlight.enabled = false;
	}

	void Update () {
		if(Input.GetKeyDown(KeyCode.R)){
			if(Flashlight.enabled == false){
				Flashlight.enabled = true;
			}
			else
			{
				Flashlight.enabled = false;
			}
		}
		if(Flashlight.enabled == true) {
			powerLevel -= 0.1f;
			Flashlight.intensity -= 0.0003f;
		}
		if(powerLevel <= 0)
		{
			Flashlight.enabled = false;
			powerLevel = 0;
		}
	}
}