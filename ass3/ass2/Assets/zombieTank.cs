using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class zombieTank : MonoBehaviour {

    public GameObject[] nodes;
    public int position = 0;

    // Use this for initialization
    void Start() {
        transform.position = nodes[0].transform.position;
        Quaternion rotation = Quaternion.LookRotation(nodes[position].transform.position - transform.position);
        Quaternion current = transform.localRotation;
        transform.localRotation = Quaternion.Slerp(current, rotation, 3 * Time.deltaTime);

    }

    // Update is called once per frame
    void Update() {

        if(isAtNodePosition() )
        {
            if (position + 1 < nodes.Length)
                position += 1;
            else
                position = 0;
        }
        else
        {
            Quaternion rotation = Quaternion.LookRotation(nodes[position].transform.position - transform.position);
            Quaternion current = transform.localRotation;
            transform.localRotation = Quaternion.Slerp(current, rotation, 3 * Time.deltaTime);
            Vector3 direction = (nodes[position].transform.position - transform.position).normalized;
            transform.position = transform.position + 3 * direction * Time.deltaTime;
        }
        
       

    }

    bool isAtNodePosition()
    {
        if (transform.position.x == nodes[position].transform.position.x && transform.position.y == nodes[position].transform.position.y)
        {
            return true;
        }
        else
            return false;
    }
}
