using UnityEngine;

public class PizzaCollisionHandler : MonoBehaviour
{
    void OnCollisionEnter(Collision collision)
    {
        // Check if the pizza collided with a meteor
        if (collision.gameObject.CompareTag("Meteor"))
        {
            Destroy(gameObject); 
            Destroy(collision.gameObject); 
        }
    }

    void OnTriggerEnter(Collider other)
    {
        
        if (other.CompareTag("Meteor"))
        {
            Destroy(gameObject);  
            Destroy(other.gameObject); 
        }
    }
}
