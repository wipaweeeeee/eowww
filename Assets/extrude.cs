using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class extrude : MonoBehaviour {

	public Transform prefab;
	// Use this for initialization
	void Start () {
		for(int i = 0; i < 10; i++) {
			Instantiate(prefab, new Vector3(i * 2.0F, 0, 0), Quaternion.identity);
		}
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
