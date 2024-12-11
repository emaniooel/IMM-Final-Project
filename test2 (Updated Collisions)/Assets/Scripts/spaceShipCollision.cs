using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spaceShipCollisions : MonoBehaviour
{
    void OnCollisionEnter(Collision collision)
    {
        //Check if the spaceship collides with meteor
        if (collision.gameObject.CompareTag("meteor"))
        {
            Destroy(gameObject); 
            Destroy(collision.gameObject); 
        }
    }

    void OnTriggerEnter(Collider other)
    {
        
        if (other.CompareTag("meteor"))
        {
            Destroy(gameObject);  
            Destroy(other.gameObject); 
        }
    }
}
