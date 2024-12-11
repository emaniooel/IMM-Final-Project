using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UIManager : MonoBehaviour
{
    public TextMeshProUGUI healthText;
    public TextMeshProUGUI pointsText;
    private int health = 100;
    private int points = 0;

    void Start()
    {
        UpdateHealth(health);
        UpdatePoints(points);
    }

    public void UpdateHealth(int currentHealth)
    {
        health = currentHealth;
        healthText.text = "Health: " + health;
    }

    public void UpdatePoints(int currentPoints)
    {
        points = currentPoints;
        pointsText.text = "Points: " + points;
    }
}
