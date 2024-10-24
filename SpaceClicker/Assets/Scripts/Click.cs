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

// g�r n�sta lektion,
// bild meny allts� klicka p� en knapp s� kommer det ut, ska skrolla.
// uppgradering, klickare fast den ger 3 klicks ist�llet f�r 1 fast kostar 300 och �kar med 40%
//POWERUPS
//
