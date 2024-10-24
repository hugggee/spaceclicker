﻿using UnityEngine;
using UnityEngine.UI;

public class OscillatorUI : MonoBehaviour
{
    [SerializeField] float radius = 100f;    
    [SerializeField] float period = 2f;       

    private RectTransform rectTransform;      
    private Vector3 startingPosition;          

    void Start()
    {
        rectTransform = GetComponent<RectTransform>(); 
        startingPosition = rectTransform.anchoredPosition; 
    }

    void Update()
    {
        if (period <= Mathf.Epsilon) return;   

       
        float cycles = Time.time / period;    
        const float tau = Mathf.PI * 2f;      
        float angle = cycles * tau;          

        
        float x = Mathf.Cos(angle) * radius;   
        float y = Mathf.Sin(angle) * radius;   

       
        Vector3 offset = new Vector3(x, y, 0); 
        rectTransform.anchoredPosition = startingPosition + offset; 
    }
}