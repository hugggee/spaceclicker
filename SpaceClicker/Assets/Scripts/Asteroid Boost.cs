using System.Collections;
using UnityEngine;

public class AsteroidSpawner : MonoBehaviour
{
   

    public GameObject asteroidPrefab; 
      
    public float boostDuration = 10f; 

    private bool asteroidActive = false;
    private float originalClickRate = 1f;
    private float boostedClickRate = 2f; 
  
    public void OnAsteroidClicked()
    {
        StartCoroutine(DoubleClickBoost());
        asteroidActive = false; 
       
    }

    IEnumerator DoubleClickBoost()
    {
        GameManager.Instance.clicksPerSecond *= boostedClickRate;
        yield return new WaitForSeconds(boostDuration);
        GameManager.Instance.clicksPerSecond = originalClickRate; 
    }
}
