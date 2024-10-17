using UnityEngine;

public class HeartbeatEffect : MonoBehaviour
{
    [SerializeField] public float pulseSpeed = 2.0f;   
    [SerializeField] public float minScale = 0.9f;      
    [SerializeField] public float maxScale = 1.1f;    
    [SerializeField] public float heartbeatDuration = 0.5f;  

    [SerializeField] private Vector3 originalScale;    
    [SerializeField] private bool isHeartbeatActive = false; 
    [SerializeField] private float heartbeatTime = 0f;  

    void Start()
    {
        
        originalScale = transform.localScale;
    }

    void Update()
    {
        if (isHeartbeatActive)
        {
            heartbeatTime += Time.deltaTime;
            float scaleChange = Mathf.PingPong(heartbeatTime * pulseSpeed, maxScale - minScale);
            transform.localScale = originalScale * (minScale + scaleChange);

            
            if (heartbeatTime >= heartbeatDuration)
            {
                isHeartbeatActive = false;
                transform.localScale = originalScale; 
            }
        }
    }

    
    public void StartHeartbeat()
    {
        isHeartbeatActive = true;
        heartbeatTime = 0f; 
    }
}