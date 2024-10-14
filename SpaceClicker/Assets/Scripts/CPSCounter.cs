using UnityEngine.UI;
using UnityEngine;
using System.Threading;

public class CPSCounter : MonoBehaviour
{
    [SerializeField] public Text cpsText;
    [SerializeField] private float clickCount = 0;
    [SerializeField] float timer = 0f;
    [SerializeField] float updateInterval = 1f;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            clickCount++;
        }


        timer += Time.deltaTime;

        if (timer > updateInterval)
        {
            cpsText.text = "CPS: " + clickCount.ToString();

            clickCount = 0;
            timer  = 0f;
        }
    }
    
}
