using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class PlayerTank : NetworkBehaviour {

    public float moveSpeed = 3;
    public float rotationSpeed = 90f;
    public GameObject bulletObject;
    public Transform bulletSpawn;

	// Update is called once per frame
	void Update () {
        
        updateMovement();	
	}

    void updateMovement()
    {

        if (!isLocalPlayer)
        {
            return;
        }
        float rotateTank = Input.GetAxis("Horizontal");
        float moveTank = Input.GetAxis("Vertical");

        GetComponent<Rigidbody>().velocity = transform.forward * moveSpeed * moveTank;

        transform.Rotate(Vector3.up * rotationSpeed * rotateTank * Time.deltaTime);

        if(Input.GetKeyDown(KeyCode.Space))
        {
            CmdFire();
        }
    }

    [Command]
    void CmdFire()
    {
        GameObject bullet = (GameObject)Instantiate(bulletObject, bulletSpawn.position, bulletSpawn.rotation);

        bullet.GetComponent<Rigidbody>().velocity = bullet.transform.forward * 6f;

        //spawn bullet on client
        NetworkServer.Spawn(bullet);

        Destroy(bulletObject, 2);
    }

    public override void OnStartLocalPlayer()
    {
        GetComponent<MeshRenderer>().material.color= Color.green;
    }

}
