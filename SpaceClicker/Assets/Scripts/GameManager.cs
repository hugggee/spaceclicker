using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;
    public float clicksPerSecond = 1f;

    private void Awake()
    {
        if (Instance == null)
            Instance = this;
        else
            Destroy(gameObject);
    }

    public void PlayerClicked()
    {
        // Handle player click logic here, for example:
        // Increase score based on clicksPerSecond
    }
}
