using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;


public class Click : MonoBehaviour
{
    public TMP_Text ClickText;
    private int click;

    public void AddClick()
    {
        click++;
        ClickText.text = "Click: " + click;
    }
   
}
