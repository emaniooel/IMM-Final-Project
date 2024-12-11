using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class meteorFalling : MonoBehaviour
{
    private float speed;

    void Start()
    {
        // Get the speed based on the current difficulty
        if (DifficultyManager.Instance != null)
        {
            speed = DifficultyManager.Instance.GetMeteorSpeed();
        }
        else
        {
            Debug.LogError("DifficultyManager not found. Defaulting to -5.0f speed.");
            speed = -5.0f; 
        }
    }

    void Update()
    {
        transform.Translate(Vector3.forward * Time.deltaTime * speed);
    }
}
