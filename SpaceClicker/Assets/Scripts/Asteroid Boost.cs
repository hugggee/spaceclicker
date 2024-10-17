using System.Collections;
using UnityEngine;

public class AsteroidSpawner : MonoBehaviour
{
    public GameObject asteroidPrefab; // Assign this in the Unity editor (drag the asteroid prefab here)
    public Transform[] spawnPoints;   // Array of possible spawn locations (assign in Unity)
    public float minTime = 1f;       // Minimum time (1 minute)
    public float maxTime = 5f;      // Maximum time (8 minutes)
    public float boostDuration = 10f; // Duration of the double click boost (in seconds)

    private bool asteroidActive = false;
    private float originalClickRate = 1f;
    private float boostedClickRate = 2f; // Double the click rate
    private float nextSpawnTime;

    private void Start()
    {
        // Set the first asteroid spawn time
        ScheduleNextAsteroid();
    }

    private void Update()
    {
        // Check if it's time to spawn a new asteroid
        if (!asteroidActive && Time.time >= nextSpawnTime)
        {
            SpawnAsteroid();
        }
    }

    void ScheduleNextAsteroid()
    {
        // Schedule the next asteroid between minTime and maxTime
        nextSpawnTime = Time.time + Random.Range(minTime, maxTime);
    }

    void SpawnAsteroid()
    {
        // Select a random spawn point from the available options
        int spawnIndex = Random.Range(0, spawnPoints.Length);
        Instantiate(asteroidPrefab, spawnPoints[spawnIndex].position, Quaternion.identity);
        asteroidActive = true; // Mark that an asteroid is currently active
    }

    // This method will be called when the asteroid is clicked
    public void OnAsteroidClicked()
    {
        StartCoroutine(DoubleClickBoost());
        asteroidActive = false; // The asteroid is consumed, deactivate it
        ScheduleNextAsteroid(); // Schedule the next asteroid appearance
    }

    IEnumerator DoubleClickBoost()
    {
        // Double the click rate for a limited time
        GameManager.Instance.clicksPerSecond *= boostedClickRate;
        yield return new WaitForSeconds(boostDuration);
        GameManager.Instance.clicksPerSecond = originalClickRate; // Reset click rate
    }
}
