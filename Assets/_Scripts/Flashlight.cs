using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flashlight : MonoBehaviour {
	public Light LuzLanterna;
	void Update () {
		if(Input.GetKeyDown(KeyCode.F)){
			LuzLanterna.enabled = !LuzLanterna.enabled;﻿
		}
	}
}
