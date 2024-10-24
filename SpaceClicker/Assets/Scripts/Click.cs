using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Click : MonoBehaviour
{
    [SerializeField] private int click;
    public HeartbeatEffect heartbeat;
    public TMP_Text clickText;
    void Start()
    {
        if (heartbeat == null)
        {
            heartbeat = GameObject.Find("ClickingButton").GetComponent<HeartbeatEffect>();
        }
        UpdateClickText();
    }

    public void AddClick()
    {
        click++;

        UpdateClickText();

        if (heartbeat != null)
        {
            heartbeat.StartHeartbeat();
        }
    }

    public void SetClicks(int amount)
    {
        click = amount;
        UpdateClickText();
    }

    public int GetCurrentClicks()
    {
        return click;
    }

    public void UpdateClickText()
    {
        if (clickText != null)
        {
            clickText.text = "" + click;
        }
    }
}

// gör nästa lektion,
// bild meny alltså klicka på en knapp så kommer det ut, ska skrolla.
// uppgradering, klickare fast den ger 3 klicks istället för 1 fast kostar 300 och ökar med 40%
//POWERUPS
//
