using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Node {

    public bool walkable;
    public Vector3 worldPosition;
    public int gridX;
    public int gridZ;

    public int gCost;
    public int hCost;
    public Node parent;
    
    public Node(bool _walkable, Vector3 _worldPos, int _gridX, int _gridZ)
    {
        walkable = _walkable;
        worldPosition = _worldPos;
        gridX = _gridX;
        gridZ = _gridZ;
    }

    public int fCost
    {
        get
        {
            return gCost + hCost;
        }
    }

    void OnMouseDown()
    {
        /*
        Debug.Log("node name: " + gameObject.name);
        Debug.Log("node coordinate: "+gameObject.transform.position);
        mazeObj.GetComponent<Pathfinder>().target_Node = gameObject.transform;
        */
    }

}
