using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOnImpact : MonoBehaviour
{
    public UIManager uiManager; 

    void Start()
    {
        //Find the UIManager in the scene if not manually assigned
        if (uiManager == null)
        {
            uiManager = FindObjectOfType<UIManager>();
            if (uiManager == null)
            {
                Debug.LogError("UIManager not found in the scene!");
            }
        }
    }

    //Detect collision with another object
    void OnTriggerEnter(Collider other)
{
    Debug.Log("Trigger detected with " + other.gameObject.name);
    
    if (other.CompareTag("Destroyable") || other.CompareTag("Meteor"))
    {
        if (other.CompareTag("Meteor") && uiManager != null)
        {
            uiManager.AddPoints(10);
            Debug.Log("Points added.");
        }

        Destroy(gameObject);
        Destroy(other.gameObject);
    }
}

    }

