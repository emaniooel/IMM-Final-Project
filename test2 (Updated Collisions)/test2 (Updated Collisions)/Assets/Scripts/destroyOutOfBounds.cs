using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{
    public float topBound = 30;       // Upper boundary at z = 50 for deletion
    public float lowerBound = -10;    // Lower boundary at z = -10 for deletion

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Destroy the object if it goes beyond the upper bound
        if (transform.position.z > topBound)
        {
            Destroy(gameObject);
        }
        // Destroy the object if it goes below the lower bound
        else if (transform.position.z < lowerBound)
        {
            Destroy(gameObject);
        }
    }
}
