using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOnImpact : MonoBehaviour
{
    // Detects collision with another object
    void OnCollisionEnter(Collision collision)
    {
        Debug.Log("Collision detected with " + collision.gameObject.name); 

        //Check if the object collided with a specific tag 
        if (collision.gameObject.CompareTag("Destroyable") || collision.gameObject.CompareTag("Meteor"))
        {
            //Destroy the object this script is attached to
            Destroy(gameObject);

            //Destroy the object it collided with
            Destroy(collision.gameObject);
        }
    }
}
