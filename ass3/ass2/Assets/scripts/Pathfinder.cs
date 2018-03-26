using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pathfinder : MonoBehaviour {

    //moving the model
    Vector3 direction;
    public float acc;
    public float acc_copy;

    public Transform model;
    public Transform curr_Node;
    public Transform target_Node;
    

    public Node[] totalNodes;
    public Node[] openList;
    public Node[] closedList;

    public float lTop_cost;
    public float top_cost;
    public float rTop_cost;

    public float left_cost;
    public float right_cost;

    public float bLeft_cost;
    public float bot_cost;
    public float bRight_cost;


	// Use this for initialization
	void Start () {
        acc_copy = acc;
		
	}
	
	// Update is called once per frame
	void FixedUpdate () {
        

        if(model.position == target_Node.position)
        {
            curr_Node = target_Node;
            acc = 0;
            direction = (target_Node.position - model.position).normalized;
            model.position = model.position + acc * direction * Time.deltaTime;
        }
        else
            if(model.position!=target_Node.position)
        {
            acc = acc_copy;
            direction = (target_Node.position - model.position).normalized;
            model.position = model.position + acc * direction * Time.deltaTime;
        }
    }
}
