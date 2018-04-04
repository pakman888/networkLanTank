using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class zombieTank : MonoBehaviour {

    public GameObject [] path = new GameObject[13];

	// Use this for initialization
	void Start () {
        transform.position = path[0].transform.position;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
