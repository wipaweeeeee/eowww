using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class extrude_2 : MonoBehaviour {

    public Transform brick;
    public Transform brickClone;
    public int numberOfObjects = 10;
    public float radius = 10f;
    float time = 1;
    float distort = 1;


	// Use this for initialization
	void Start () {
        //Instantiate(brick, new Vector3(0,0,0), Quaternion.Euler(0, 180, 0));
	}

    void drawStuff() {
        float angle = (time * Mathf.PI / 2) / numberOfObjects;
        brick.transform.localScale = new Vector3(distort, 1, 7);
        Vector3 pos = new Vector3(Mathf.Sin(angle), 0, Mathf.Cos(angle)) * radius;
        Instantiate(brick, pos, Quaternion.Euler(0, 180, 0));
    }
	
	//Update is called once per frame
	void Update () {
        if (distort > 2) {
            distort -= 0.01f;
        } else {
            distort += 0.01f;
        }

        time+=0.1f;
        if (time < 20)
        {
            drawStuff();
        }


	}
}
