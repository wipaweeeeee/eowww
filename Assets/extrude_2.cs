using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class extrude_2 : MonoBehaviour {

    public Transform brick;
    public Transform brickClone;
    public int numberOfObjects = 10;
    public float radius = 10f;
    float time = 1;


	// Use this for initialization
	void Start () {
        //for (int i = 0; i < numberOfObjects; i++)
        //{
        //    float angle = (i * Mathf.PI / 3) / numberOfObjects;
        //    Vector3 pos = new Vector3(Mathf.Cos(angle*10*Time.deltaTime), 0, Mathf.Sin(angle*10*Time.deltaTime)) * radius;
        //    Instantiate(brick, pos, Quaternion.Euler(0, 180, 0));
        //    //brickClone = Instantiate(brick, new Vector3(0, 0, i), Quaternion.Euler(0, 180, 0));
        //}

	}

    void drawStuff() {
        float angle = (time * Mathf.PI / 3) / numberOfObjects;
        Debug.Log(angle);
        Vector3 pos = new Vector3(Mathf.Cos(angle), Mathf.Sin(-angle)*Mathf.Cos(angle), Mathf.Sin(angle)) * radius;
        Instantiate(brick, pos, Quaternion.Euler(0, 180, 0));
    }
	
	//Update is called once per frame
	void Update () {

        time+=0.1f;
        if (time < 20)
        {
            drawStuff();
        }


	}
}
