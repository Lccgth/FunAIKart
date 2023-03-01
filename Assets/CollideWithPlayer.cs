using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollideWithPlayer : MonoBehaviour
{
    // detect collide with player
    private void OnCollisionEnter(Collision collision)      
    {
        if(collision.gameObject.tag == "Player")
        {
            // print("collide with player!");
            this.gameObject.SetActive(false);
        }
    }
}
