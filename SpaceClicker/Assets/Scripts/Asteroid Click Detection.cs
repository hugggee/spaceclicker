using UnityEngine;

public class Asteroid : MonoBehaviour
{
    private void OnMouseDown()
    {
        FindObjectOfType<AsteroidSpawner>().OnAsteroidClicked();
        Destroy(gameObject); // Remove asteroid after it's clicked
    }
}
