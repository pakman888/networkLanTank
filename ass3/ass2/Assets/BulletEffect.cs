using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletEffect : MonoBehaviour {

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.name!="zombieTankAI" )
        {

            if (collision.gameObject.name == "powerSpeed"
           || collision.gameObject.name == "powerBullet" || collision.gameObject.name == "powerRock"
           || collision.gameObject.name == "powerShrink")
            {

                Destroy(this.gameObject);
            }
            else
            {

                Destroy(collision.gameObject);
                Destroy(this.gameObject);
            }

        }
        else
        {
            Destroy(this.gameObject);
        }

        

    }
}
