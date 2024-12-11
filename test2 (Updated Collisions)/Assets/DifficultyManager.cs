using UnityEngine;

public class DifficultyManager : MonoBehaviour
{
    public static DifficultyManager Instance; 

    public enum Difficulty { Easy, Medium, Hard }
    public Difficulty currentDifficulty = Difficulty.Easy;

    private void Awake()
    {
        
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    public float GetMeteorSpeed()
    {
       
        switch (currentDifficulty)
        {
            case Difficulty.Medium:
                return -10.0f;
            case Difficulty.Hard:
                return -15.0f;
            default:
                return -5.0f;
        }
    }

    public void SetDifficulty(Difficulty difficulty)
    {
        currentDifficulty = difficulty;
        Debug.Log($"Difficulty set to: {currentDifficulty}");
    }
}
