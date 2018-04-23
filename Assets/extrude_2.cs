using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class extrude_2 : MonoBehaviour {

    public Transform brick;

	// Use this for initialization
	void Start () {
        for (int i = 0; i < 10; i++)
        {
            Instantiate(brick, new Vector3(0, 0, i), Quaternion.Euler(0, 180, 0));
        }
	}
	
	// Update is called once per frame
	//void Update () {
		
	//}
}
