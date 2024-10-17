using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Click : MonoBehaviour
{
    public TMP_Text ClickText;         
    private int click;                 
    public HeartbeatEffect heartbeat;   

    void Start()
    {
        
        if (heartbeat == null)
        {
           
            heartbeat = GameObject.Find("ClickingButton").GetComponent<HeartbeatEffect>();
        }
    }

    public void AddClick()
    {
        click++;
        ClickText.text = "Click: " + click;

        
        if (heartbeat != null)
        {
            heartbeat.StartHeartbeat();
        }
    }
}