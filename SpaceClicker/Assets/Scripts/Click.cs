using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Click : MonoBehaviour
{
    [SerializeField] public TMP_Text ClickText;
    [SerializeField] private int click;
    [SerializeField] public HeartbeatEffect heartbeat;

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