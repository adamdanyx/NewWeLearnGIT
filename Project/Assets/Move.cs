﻿using UnityEngine;
using System.Collections;

public class Move : MonoBehaviour {

	float speed = 1.0f;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		transform.Translate (Vector3.up * Time.deltaTime * speed);
	}
}
